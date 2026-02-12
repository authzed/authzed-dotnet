namespace Authzed.Net.Tests;

using Authzed.Api.V1;
using Google.Protobuf.WellKnownTypes;

public class V1Test
{
    [Fact]
    public async Task TestBasicSchema()
    {
        var client = new TestClient();
        string schema = @"
            definition document {
                relation reader: user
            }
            definition user {}
        ";
        var writeResponse = await client.schemaService.WriteSchemaAsync(new WriteSchemaRequest { Schema = schema });
        Assert.NotEmpty(writeResponse.WrittenAt.ToString());
        var response = await client.schemaService.ReadSchemaAsync(new ReadSchemaRequest { });
        Assert.Contains("definition document", response.SchemaText);
        Assert.Contains("definition user", response.SchemaText);
    }

    [Fact]
    public async Task TestSchemaWithCaveats()
    {
        var client = new TestClient();
        await WriteTestSchema(client);
    }

    [Fact]
    public async Task TestCheck()
    {
        var client = new TestClient();
        await WriteTestSchema(client);
        var (emilia, beatrice, postOne, postTwo) = await WriteTestTuples(client);
        var firstResponse = await client.permissionsService.CheckPermissionAsync(new CheckPermissionRequest
        {
            Resource = postOne,
            Permission = "view",
            Subject = emilia,
            Consistency = new Consistency { FullyConsistent = true }
        });
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.HasPermission, firstResponse.Permissionship);

        var secondResponse = await client.permissionsService.CheckPermissionAsync(new CheckPermissionRequest
        {
            Resource = postOne,
            Permission = "write",
            Subject = emilia,
            Consistency = new Consistency { FullyConsistent = true }
        });
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.HasPermission, secondResponse.Permissionship);

        var thirdResponse = await client.permissionsService.CheckPermissionAsync(new CheckPermissionRequest
        {
            Resource = postOne,
            Permission = "view",
            Subject = beatrice,
            Consistency = new Consistency { FullyConsistent = true }
        });
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.HasPermission, thirdResponse.Permissionship);

        var fourthResponse = await client.permissionsService.CheckPermissionAsync(new CheckPermissionRequest
        {
            Resource = postOne,
            Permission = "write",
            Subject = beatrice,
            Consistency = new Consistency { FullyConsistent = true }
        });
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.NoPermission, fourthResponse.Permissionship);
    }

    [Fact]
    public async Task TestCaveatedCheck()
    {
        var client = new TestClient();
        await WriteTestSchema(client);
        var (emilia, beatrice, postOne, postTwo) = await WriteTestTuples(client);

        // Likes Harry Potter
        var likesContext = new Struct { Fields = { ["likes"] = Value.ForBool(true) } };
        var firstResponse = await client.permissionsService.CheckPermissionAsync(new CheckPermissionRequest
        {
            Resource = postOne,
            Permission = "view_as_fan",
            Subject = beatrice,
            Consistency = new Consistency { FullyConsistent = true },
            Context = likesContext,
        });
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.HasPermission, firstResponse.Permissionship);

        // No longer likes Harry Potter
        var dislikesContext = new Struct { Fields = { ["likes"] = Value.ForBool(false) } };
        var secondResponse = await client.permissionsService.CheckPermissionAsync(new CheckPermissionRequest
        {
            Resource = postOne,
            Permission = "view_as_fan",
            Subject = beatrice,
            Consistency = new Consistency { FullyConsistent = true },
            Context = dislikesContext,
        });
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.NoPermission, secondResponse.Permissionship);

        // Fandom is in question
        var thirdResponse = await client.permissionsService.CheckPermissionAsync(new CheckPermissionRequest
        {
            Resource = postOne,
            Permission = "view_as_fan",
            Subject = beatrice,
            Consistency = new Consistency { FullyConsistent = true },
        });
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.ConditionalPermission, thirdResponse.Permissionship);
        Assert.Contains("likes", thirdResponse.PartialCaveatInfo.MissingRequiredContext);
    }

    [Fact]
    public async Task TestLookupResources()
    {
        var client = new TestClient();
        await WriteTestSchema(client);
        var (emilia, beatrice, postOne, postTwo) = await WriteTestTuples(client);

        using var call = client.permissionsService.LookupResources(new LookupResourcesRequest
        {
            ResourceObjectType = "post",
            Permission = "write",
            Subject = emilia,
            Consistency = new Consistency { FullyConsistent = true },
        });

        var postIds = new List<string> { };
        await foreach (var response in call.ResponseStream.ReadAllAsync())
        {
            postIds.Add(response.ResourceObjectId);
        }

        Assert.Contains(postOne.ObjectId, postIds);
        Assert.Contains(postTwo.ObjectId, postIds);
        Assert.Equal(2, postIds.Count);
    }

    [Fact]
    public async Task TestLookupSubjects()
    {
        var client = new TestClient();
        await WriteTestSchema(client);
        var (emilia, beatrice, postOne, postTwo) = await WriteTestTuples(client);

        using var call = client.permissionsService.LookupSubjects(new LookupSubjectsRequest
        {
            SubjectObjectType = "user",
            Permission = "view",
            Resource = postOne,
            Consistency = new Consistency { FullyConsistent = true },
        });

        var userIds = new List<string> { };
        await foreach (var response in call.ResponseStream.ReadAllAsync())
        {
            userIds.Add(response.Subject.SubjectObjectId);
        }

        Assert.Contains(emilia.Object.ObjectId, userIds);
        Assert.Contains(beatrice.Object.ObjectId, userIds);
        Assert.Equal(2, userIds.Count);
    }

    [Fact]
    public async Task TestCheckBulkPermissions()
    {
        var client = new TestClient();
        await WriteTestSchema(client);
        var (emilia, beatrice, postOne, postTwo) = await WriteTestTuples(client);

        var response = await client.permissionsService.CheckBulkPermissionsAsync(new CheckBulkPermissionsRequest
        {
            Consistency = new Consistency { FullyConsistent = true },
            Items ={
                new CheckBulkPermissionsRequestItem{
                Resource=postOne,
                Permission="view",
                Subject=emilia,
                },
                new CheckBulkPermissionsRequestItem{
                Resource=postOne,
                Permission="write",
                Subject=emilia,
                },
                }
        });

        Assert.Equal(2, response.Pairs.Count);
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.HasPermission, response.Pairs[0].Item.Permissionship);
        Assert.Equivalent(CheckPermissionResponse.Types.Permissionship.HasPermission, response.Pairs[1].Item.Permissionship);
    }

    [Fact]
    public async Task TestBulkExportImport()
    {
        var client = new TestClient();
        await WriteTestSchema(client);
        await WriteTestTuples(client);

        // Validate export
        using var exportCall = client.experimentalService.BulkExportRelationships(new BulkExportRelationshipsRequest
        {
            Consistency = new Consistency { FullyConsistent = true }
        });

        var relations = new List<Relationship> { };
        await foreach (var response in exportCall.ResponseStream.ReadAllAsync())
        {
            relations.AddRange(response.Relationships);
        }

        Assert.Equal(4, relations.Count);

        // Note that this has a different preshared key
        // Validate import
        var emptyClient = new TestClient();
        await WriteTestSchema(emptyClient);
        using var importCall = emptyClient.experimentalService.BulkImportRelationships();
        await importCall.RequestStream.WriteAsync(new BulkImportRelationshipsRequest
        {
            Relationships = { relations }
        });
        await importCall.RequestStream.CompleteAsync();
        var importResponse = await importCall;

        Assert.Equal(4.0, importResponse.NumLoaded);

        // Validate that things were loaded
        using var postImportExportCall = emptyClient.experimentalService.BulkExportRelationships(new BulkExportRelationshipsRequest
        {
            Consistency = new Consistency { FullyConsistent = true }
        });

        var importedRelations = new List<Relationship> { };
        await foreach (var response in postImportExportCall.ResponseStream.ReadAllAsync())
        {
            importedRelations.AddRange(response.Relationships);
        }

        Assert.Equal(4, importedRelations.Count);
    }

    private async Task<(SubjectReference, SubjectReference, ObjectReference, ObjectReference)> WriteTestTuples(TestClient client)
    {
        var emilia = new SubjectReference
        {
            Object = new ObjectReference
            {
                ObjectType = "user",
                ObjectId = "emilia"
            }
        };
        var beatrice = new SubjectReference
        {
            Object = new ObjectReference
            {
                ObjectType = "user",
                ObjectId = "beatrice"
            }
        };
        var postOne = new ObjectReference { ObjectType = "post", ObjectId = "post-one" };
        var postTwo = new ObjectReference { ObjectType = "post", ObjectId = "post-two" };
        await client.permissionsService.WriteRelationshipsAsync(new WriteRelationshipsRequest
        {
            Updates ={
                // Emilia is a Writer on Post 1
                new RelationshipUpdate{
                Operation=RelationshipUpdate.Types.Operation.Create,
                Relationship=new Relationship{
                Resource=postOne,
                Relation="writer",
                Subject=emilia,
                }
                },
                // Emilia is a Writer on Post 2
                new RelationshipUpdate{
                Operation=RelationshipUpdate.Types.Operation.Create,
                Relationship=new Relationship{
                Resource=postTwo,
                Relation="writer",
                Subject=emilia,
                }
                },
                // Beatrice is a Reader on Post 1
                new RelationshipUpdate{
                Operation=RelationshipUpdate.Types.Operation.Create,
                Relationship=new Relationship{
                Resource=postOne,
                Relation="reader",
                Subject=beatrice,
                }
                },
                // Beatrice is also a caveated Reader on Post 1
                new RelationshipUpdate{
                Operation=RelationshipUpdate.Types.Operation.Create,
                Relationship=new Relationship{
                Resource=postOne,
                Relation="caveated_reader",
                Subject=beatrice,
                OptionalCaveat=new ContextualizedCaveat{CaveatName="likes_harry_potter"}
                }
                },
                }
        });
        return (emilia, beatrice, postOne, postOne);
    }
    private async Task WriteTestSchema(TestClient client)
    {
        string schema = @"
            caveat likes_harry_potter(likes bool) {
              likes == true
            }

            definition post {
                relation writer: user
                relation reader: user
                relation caveated_reader: user with likes_harry_potter

                permission write = writer
                permission view = reader + writer
                permission view_as_fan = caveated_reader + writer
            }
            definition user {}
        ";
        await client.schemaService.WriteSchemaAsync(new WriteSchemaRequest { Schema = schema });
    }
}
