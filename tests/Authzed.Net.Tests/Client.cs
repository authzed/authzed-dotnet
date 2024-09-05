namespace Authzed.Net.Tests;

using Authzed.Api.V1;
using Grpc.Core;
using Grpc.Net.Client;
public class TestClient {
    public SchemaService.SchemaServiceClient schemaService;
    public PermissionsService.PermissionsServiceClient permissionsService;
    public TestClient(string target, string token) {
        var credentials = CallCredentials.FromInterceptor((context, metadata) =>
    {
        metadata.Add("Authorization", $"Bearer {token}");
        return Task.CompletedTask;
    });
        var options = new GrpcChannelOptions{
            UnsafeUseInsecureChannelCallCredentials = true,
            Credentials = ChannelCredentials.Create(ChannelCredentials.Insecure, credentials),
        };
        var channel = GrpcChannel.ForAddress(target, options);
        schemaService = new SchemaService.SchemaServiceClient(channel);
        permissionsService = new PermissionsService.PermissionsServiceClient(channel);
    }
}
