using System.Net.Http.Json;

using Example.Context;
using Example.Model;

using Microsoft.Extensions.DependencyInjection;

namespace ExampleTest;

[Collection("IntegrationTests")]
public class ExampleIntegrationTest(ExampleApplicationFactory app) : IClassFixture<ExampleApplicationFactory>
{
    [Fact]
    public async Task ExampleTest()
    {
        // Example of what kind of exception message is thrown in case this test fails:
        // Services for database providers 'Microsoft.EntityFrameworkCore.Sqlite',
        // 'Microsoft.EntityFrameworkCore.InMemory' have been registered in the service provider.
        // Only a single database provider can be registered in a service provider.
        // If possible, ensure that Entity Framework is managing its service provider by removing the
        // all to 'UseInternalServiceProvider'. Otherwise, consider conditionally registering
        // the database provider, or maintaining one service provider per database provider.

        using var scope = app.Services.CreateScope();
        await using var context = scope.ServiceProvider.GetRequiredService<ExampleContext>();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        context.Cities.Add(new City { Name = "London" });
        await context.SaveChangesAsync();

        var cities = context.Cities.ToList();
        Assert.Single(cities);
        Assert.Equal("London", cities[0].Name);
    }
}