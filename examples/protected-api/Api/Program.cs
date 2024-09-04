// Credit to https://medium.com/kpmg-uk-engineering/getting-started-with-spicedb-in-net-741e353a4d83
// for the example.
using Authzed.Api.V1;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

void ConfigureSpiceDbGrpcClient(IServiceProvider provider, GrpcClientFactoryOptions options)
{
    options.Address = new Uri("http://localhost:50051");
}

void ConfigureSpiceDbChannel(IServiceProvider provider, GrpcChannelOptions options)
{
    var credentials = CallCredentials.FromInterceptor((context, metadata) =>
    {
        const string token = "lovelycoconuts"; // NOTE - this will need to come from config eventually
        metadata.Add("Authorization", $"Bearer {token}");
        return Task.CompletedTask;
    });

    // NOTE - we're using Insecure credentials only for this demo so that we don't need to setup TLS
    options.UnsafeUseInsecureChannelCallCredentials = true;
    options.Credentials = ChannelCredentials.Create(ChannelCredentials.Insecure, credentials);
}

builder.Services.AddGrpcClient<PermissionsService.PermissionsServiceClient>(ConfigureSpiceDbGrpcClient)
    .ConfigureChannel(ConfigureSpiceDbChannel);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var groups = new[]
{
    new { Name = "devs" },
    new { Name = "qa" },
    new { Name = "designers" },
};

// adds a new endpoint for getting a single group
app.MapGet("/groups/{groupName}", async (
        [FromRoute] string groupName,
        [FromServices] PermissionsService.PermissionsServiceClient client,
        [FromHeader] string userName) =>
{
    var group = groups.FirstOrDefault(g => g.Name == groupName);
    if (group is null)
    {
        return Results.NotFound();
    }

    var permission = await client.CheckPermissionAsync(new CheckPermissionRequest
    {
        Consistency = new Consistency
        {
            FullyConsistent = true
        },
        Subject = new SubjectReference
        {
            Object = new ObjectReference
            {
                ObjectType = "user",
                ObjectId = userName
            }
        },
        // Note - This string needs to match a permission from our schema
        Permission = "can_view_group",
        Resource = new ObjectReference
        {
            ObjectType = "group",
            ObjectId = groupName
        }
    });

    if (permission.Permissionship != CheckPermissionResponse.Types.Permissionship.HasPermission)
    {
        return Results.StatusCode(403);
    }

    return Results.Ok(group);
})
.WithName("GetGroup")
.WithTags("Groups")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
