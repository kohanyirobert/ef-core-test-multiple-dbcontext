using Example.Context;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleTest;

public class ExampleApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            services.Remove(services.Single(service => typeof(DbContextOptions<ExampleContext>) == service.ServiceType));
            services.AddDbContext<ExampleContext>(options => options.UseInMemoryDatabase("Example"));
        });
    }
}