# About

Repo and code to reproduce this error:

```
ExampleTest.ExampleIntegrationTest.WhenTestReplacesDbContextOptions_NoErrorIsThrown (257ms): Error Message: System.InvalidOperationException : Services for
    database providers 'Microsoft.EntityFrameworkCore.Sqlite', 'Microsoft.EntityFrameworkCore.InMemory' have been registered in the service provider.
    Only a single database provider can be registered in a service provider. If possible, ensure that Entity Framework is managing its service provider
    by removing the call to 'UseInternalServiceProvider'. Otherwise, consider conditionally registering the database provider, or maintaining one
    service provider per database provider.
```

Compare these brances to see the difference:
- `main`
- `alternative`
- `fail`

Main differnces are:ű
- `main` and `fail` uses 9.0.2 of Entity Framework Core dependencies
- `alternative` is using 8.0.13
- `fail` and `alternative` uses the "old way of doing things"
- `main` the "new way" (see [related blog post](https://jackyasgar.net/solved-ef-8-to-9-migration-database-provider-exception/))