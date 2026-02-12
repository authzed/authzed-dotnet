namespace Authzed.Net.Tests;

using Authzed.Api.V1;
using Grpc.Net.Client;
using System;
public class TestClient
{
    public SchemaService.SchemaServiceClient schemaService;
    public PermissionsService.PermissionsServiceClient permissionsService;
    public ExperimentalService.ExperimentalServiceClient experimentalService;
    public TestClient()
    {
        // NOTE: this has to be declared here because the interceptor
        // lambda is run on every request invocation.
        var token = Guid.NewGuid().ToString();
        var credentials = CallCredentials.FromInterceptor((context, metadata) =>
    {
        metadata.Add("Authorization", $"Bearer {token}");
        return Task.CompletedTask;
    });
        var options = new GrpcChannelOptions
        {
            UnsafeUseInsecureChannelCallCredentials = true,
            Credentials = ChannelCredentials.Create(ChannelCredentials.Insecure, credentials),
        };
        var channel = GrpcChannel.ForAddress("http://localhost:50051", options);
        schemaService = new SchemaService.SchemaServiceClient(channel);
        permissionsService = new PermissionsService.PermissionsServiceClient(channel);
        experimentalService = new ExperimentalService.ExperimentalServiceClient(channel);
    }
}
