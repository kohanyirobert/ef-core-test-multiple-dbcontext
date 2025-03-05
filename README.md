# About

Repo and code to reproduce this error:

```
ExampleTest.ExampleIntegrationTest.ExampleTest (572ms): Error Message: System.InvalidOperationException : Services for database providers 'Microsoft.EntityFrameworkCore.Sqlite', 'Microsoft.EntityFrameworkCore.InMemory' have been registered in the service provider. Only a single database provider can be registered in a service provider. If possible, ensure that Entity Framework is managing its service provider by removing the call to 'UseInternalServiceProvider'. Otherwise, consider conditionally registering the database provider, or maintaining one service provider per database provider.
```

Compare these brances to see the difference:
- main
- fail