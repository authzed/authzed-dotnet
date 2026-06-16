## Description
This is a simple Kestrel server that has an endpoint that makes a call to SpiceDB.
It uses the service dependency injection mechanism to stand up the gRPC services
and provide them to the endpoint.

## Running the project
In a separate terminal, set up a running spicedb instance. `--pull always`
ensures you get a current image; a stale locally-cached `authzed/spicedb`
predating the v1 PermissionsService is the usual cause of
`unknown service authzed.api.v1.PermissionsService` errors.
```bash
docker run --pull always --rm -p 50051:50051 authzed/spicedb serve --grpc-preshared-key lovelycoconuts
```

Write the schema from the resources folder to the SpiceDB server:

```bash
zed schema write Resources/example.zed --insecure --token lovelycoconuts
```

Write a couple of relationships to the instance:
```bash
zed relationship touch group:devs admin user:bob --insecure --token lovelycoconuts
zed relationship touch group:devs member user:alice --insecure --token lovelycoconuts
```

Then run the project from the directory the project is in (or using your IDE):
```bash
dotnet run --project Api
```

You should then be able to view the project at http://localhost:5000/swagger/index.html and interact with the API.
Try passing a `groupName` of `devs` and a `userName` of `bob`, and then see what happens when you change the `userName` to
`robert`.

## Credit
This was adapted from https://medium.com/kpmg-uk-engineering/getting-started-with-spicedb-in-net-741e353a4d83.
