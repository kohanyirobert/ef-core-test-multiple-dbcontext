# About

Repo and code to reproduce this error:
```
ExampleTest.ExampleIntegrationTest.ExampleTest (572ms): Error Message: System.InvalidOperationException : Services for database providers 'M
      icrosoft.EntityFrameworkCore.Sqlite', 'Microsoft.EntityFrameworkCore.InMemory' have been registered in the service provider. Only a single d
      atabase provider can be registered in a service provider. If possible, ensure that Entity Framework is managing its service provider by remo
      ving the call to 'UseInternalServiceProvider'. Otherwise, consider conditionally registering the database provider, or maintaining one servi
      ce provider per database provider.
```