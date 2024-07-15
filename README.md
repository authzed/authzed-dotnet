# authzed dotnet
[![](https://img.shields.io/badge/discord-spicedb-7289da?style=flat-square "Discord Badge")](https://discord.gg/spicedb)
[![](https://img.shields.io/badge/twitter-@authzed-1d9bf0.svg?style=flat-square "Twitter Badge")](https://twitter.com/authzed)
[![](https://img.shields.io/badge/linkedin-+authzed-2D65BC.svg?style=flat-square "LinkedIn Badge")](https://linkedin.com/company/authzed)

This repository houses the official .NET (generated in C#) client library for Authzed and SpiceDB.

This project is intended to be a canonical source of generated ProtoBuf messages for gRPC communication.

[SpiceDB] is a database system for managing security-critical permissions checking.

SpiceDB acts as a centralized service that stores authorization data.
Once stored, data can be performantly queried to answer questions such as "Does this user have access to this resource?" and "What are all the resources this user has access to?".

[Authzed] operates the globally available, serverless database platform for SpiceDB.

You can find more info about the API in the [Authzed Documentation API Reference] or the [Authzed API Buf Registry repository].

See [CONTRIBUTING.md] for instructions on how to contribute and perform common tasks like building the project and running tests.

[SpiceDB]: https://github.com/authzed/spicedb
[Authzed]: https://authzed.com
[Authzed Documentation API Reference]: https://docs.authzed.com/reference/api
[Authzed API Buf Registry repository]: https://buf.build/authzed/api
[CONTRIBUTING.md]: CONTRIBUTING.md
[Discord]: https://authzed.com/discord
[Urgent]: https://github.com/authzed/authzed-rb/labels/priority%2F0%20urgent
[High]: https://github.com/authzed/authzed-rb/labels/priority%2F1%20high
[Medium]: https://github.com/authzed/authzed-rb/labels/priority%2F2%20medium
[Low]: https://github.com/authzed/authzed-rb/labels/priority%2F3%20low
[Maybe]: https://github.com/authzed/authzed-rb/labels/priority%2F4%20maybe
[good first issues]: https://github.com/authzed-rb/spicedb/labels/hint%2Fgood%20first%20issue

## Installation

```sh
nuget install authzed-dot
```
