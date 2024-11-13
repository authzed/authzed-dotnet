/*
 * This is intended to be a (somewhat) real-world example of
 * ImportBulkRelationships usage. It demonstrates chunking both across
 * requests and within the request to optimize both for transaction
 * size and network traffic.
 */
using Authzed.Api.V1;
using Grpc.Net.Client;
using Grpc.Core;

var TOKEN = "sometoken";

var TOTAL_RELATIONSHIPS_TO_WRITE = 1000;
var RELATIONSHIPS_PER_TRANSACTION = 100;
var RELATIONSHIPS_PER_REQUEST_CHUNK = 10;

// A function that returns an iterator, which we'll use to generate our imported relationships.
IEnumerable<Relationship> GetRelationships(int numRelationships) {
    var idx = 0;
    while (idx < numRelationships) {
        idx += 1;
        yield return new Relationship{
            Resource = new ObjectReference{ ObjectId = idx.ToString(), ObjectType = "resource"},
            Relation = "viewer",
            Subject = new SubjectReference{ Object = new ObjectReference{ ObjectId = "our_user", ObjectType = "user" }},
        };
    }
    yield break;
}

// Set up the client
var credentials = CallCredentials.FromInterceptor((context, metadata) =>
        {
        metadata.Add("Authorization", $"Bearer {TOKEN}");
        return Task.CompletedTask;
        });

var options = new GrpcChannelOptions
{
    UnsafeUseInsecureChannelCallCredentials = true,
                                            Credentials = ChannelCredentials.Create(ChannelCredentials.Insecure, credentials),
};

var channel = GrpcChannel.ForAddress("http://localhost:50051", options);

var schemaService = new SchemaService.SchemaServiceClient(channel);
var permissionsService = new PermissionsService.PermissionsServiceClient(channel);

// Write a schema
var schema = @"
    definition user {}
    definition resource {
        relation viewer: user
        permission view = viewer
    }
";

await schemaService.WriteSchemaAsync(new WriteSchemaRequest { Schema = schema });

// Start by breaking the full list into a sequence of chunks where each chunk fits easily
// into a datastore transaction.
var transactionChunks = GetRelationships(TOTAL_RELATIONSHIPS_TO_WRITE).Chunk(RELATIONSHIPS_PER_TRANSACTION);

foreach (var relationshipsForRequest in transactionChunks) {
    // For each of those transaction chunks, break it down further into chunks that
    // optimize for network throughput.
    var requestChunks = relationshipsForRequest.Chunk(RELATIONSHIPS_PER_REQUEST_CHUNK);
    // Open up a client stream to the server for this transaction chunk
    using var importCall = permissionsService.ImportBulkRelationships();
    foreach (var requestChunk in requestChunks) {
        // For each network chunk, write to the client stream.
        // NOTE: this makes the calls sequentially rather than concurrently; this could be
        // optimized further by using tasks.
        await importCall.RequestStream.WriteAsync(new ImportBulkRelationshipsRequest{
                Relationships = { requestChunk }
                });
    }
    // When we're done with the transaction chunk, complete the call and process the response.
    await importCall.RequestStream.CompleteAsync();
    var importResponse = await importCall;
    Console.WriteLine("request successful");
    Console.WriteLine(importResponse.NumLoaded);
    // Repeat!
}
