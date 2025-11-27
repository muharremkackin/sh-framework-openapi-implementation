# SH.Framework.OpenApi.Implementation

A comprehensive implementation layer for OpenAPI integration in ASP.NET Core projects. This package provides extension methods and helpers for customizing OpenAPI schema generation, including friendly schema reference IDs and configuration registration.

## Features
- Custom schema reference ID generation for OpenAPI documents
- Extension methods for easy OpenAPI configuration
- Compatible with .NET 8, .NET 9, and .NET 10

## Installation
Add the NuGet package to your project:

```
dotnet add package SH.Framework.OpenApi.Implementation
```

## Usage
Register OpenAPI configuration in your `Startup.cs` or program setup:

```csharp
services.AddOpenApiConfiguration();
```

This enables custom schema reference ID generation for your OpenAPI documents.

## License
This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.

## Repository
[GitHub Repository](https://github.com/muharremkackin/sh-framework-openapi-implementation)
