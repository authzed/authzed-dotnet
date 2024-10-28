# Authzed.Net
[![Nuget](https://img.shields.io/nuget/v/Authzed.Net?color=%23006dad)](https://www.nuget.org/packages/Authzed.Net)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![Build Status](https://github.com/authzed/authzed-dotnet/workflows/Test/badge.svg)](https://github.com/authzed/authzed-dotnet/actions)
[![Mailing List](https://img.shields.io/badge/email-google%20groups-4285F4)](https://groups.google.com/g/authzed-oss)
[![Discord Server](https://img.shields.io/badge/discord-spicedb-7289da?style=flat-square "Discord Badge")](https://discord.gg/spicedb)
[![Twitter](https://img.shields.io/badge/twitter-@authzed-1d9bf0.svg?style=flat-square "Twitter Badge")](https://twitter.com/authzed)
[![LinkedIn](https://img.shields.io/badge/linkedin-+authzed-2D65BC.svg?style=flat-square "LinkedIn Badge")](https://linkedin.com/company/authzed)

This repository houses the official .NET (generated in C#) client library for Authzed and SpiceDB.

[SpiceDB] is a database and service that stores, computes, and validates your application's permissions.

Developers create a schema that models their permissions requirements and use a client library, such as this one, to apply the schema to the database, insert data into the database, and query the data to efficiently check permissions in their applications.

Supported client API versions:

- [v1](https://docs.authzed.com/reference/api#authzedapiv1)

You can find more info on each API on the [Authzed API reference documentation].
Additionally, Protobuf API documentation can be found on the [Buf Registry Authzed API repository].

See [CONTRIBUTING.md] for instructions on how to contribute and perform common tasks like building the project and running tests.

[SpiceDB]: https://github.com/authzed/spicedb
[Authzed API Reference documentation]: https://docs.authzed.com/reference/api
[Buf Registry Authzed API repository]: https://buf.build/authzed/api/docs/main
[CONTRIBUTING.md]: CONTRIBUTING.md

[SpiceDB]: https://github.com/authzed/spicedb
[Discord]: https://authzed.com/discord
[Urgent]: https://github.com/authzed/authzed-rb/labels/priority%2F0%20urgent
[High]: https://github.com/authzed/authzed-rb/labels/priority%2F1%20high
[Medium]: https://github.com/authzed/authzed-rb/labels/priority%2F2%20medium
[Low]: https://github.com/authzed/authzed-rb/labels/priority%2F3%20low
[Maybe]: https://github.com/authzed/authzed-rb/labels/priority%2F4%20maybe
[good first issues]: https://github.com/authzed-rb/spicedb/labels/hint%2Fgood%20first%20issue

## Getting Started

We highly recommend following the **[Protecting Your First App]** guide to learn the latest best practice to integrate an application with Authzed.

If you're interested in example usages, including integration with a Kestrel API, they can be found in their respective folders in the [examples directory].

[Protecting Your First App]: https://docs.authzed.com/guides/first-app
[examples directory]: /examples

## Basic Usage
### Installation

With [`dotnet`](https://learn.microsoft.com/en-us/dotnet/core/install/):
```sh
dotnet add package Authzed.Net
```

With [`nuget`](https://www.nuget.org/downloads):
```sh
nuget install Authzed.Net
```

### Initializing a Client

Currently, everything required to connect and make API calls is located in a module respective to API version.

In order to successfully connect, you will have to provide a [Bearer Token] with your own API Token from the [Authzed dashboard] in place of `t_your_token_here_1234567deadbeef` in the following example.

[grpc]: https://grpc.io
[Bearer Token]: https://datatracker.ietf.org/doc/html/rfc6750#section-2.1
[Authzed Dashboard]: https://app.authzed.com

```csharp
using Authzed.Api.V1;
using Grpc.Core;
using Grpc.Net.Client;
using System;

// In some other block
var token = "my super secret key"
var credentials = CallCredentials.FromInterceptor((context, metadata) =>
{
    metadata.Add("Authorization", $"Bearer {token}");
    return Task.CompletedTask;
});

var options = new GrpcChannelOptions
{
    Credentials = ChannelCredentials.Create(new SslCredentials(), credentials),
};
var channel = GrpcChannel.ForAddress("https://my.spicedb.service:50051", options);
var client = new PermissionsService.PermissionsServiceClient(channel);
```

Note that the above example shows the Permission client specifically; a fully working flow will also require the Schema service.

Also note that we're using TLS. For an example that does not use TLS, see the API in the [examples directory].

### Performing an API Request
```csharp
using Authzed.Api.V1;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

// Continuing from above
var response = await client.CheckPermissionAsync(new CheckPermissionRequest
{
    Resource = new ObjectReference { ObjectType = "post", ObjectId = "post-one" },
    Permission = "view",
    Subject = new SubjectReference
    {
        Object = new ObjectReference
        {
            ObjectType = "user",
            ObjectId = "emilia"
        }
    },
    Consistency = new Consistency { FullyConsistent = true }
});
Console.WriteLine(response.Permissionship)
```
