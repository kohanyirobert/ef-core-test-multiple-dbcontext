using Example.Model;

using Microsoft.EntityFrameworkCore;

namespace Example.Context;

public class ExampleContext(DbContextOptions<ExampleContext> options) : DbContext(options)
{
    public DbSet<City> Cities { get; set; }
}