using Example.Context;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ExampleContext>(options =>
{
    var dbPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ".db");
    options.UseSqlite($"Data Source={dbPath}");
});
var app = builder.Build();
app.Run();

public abstract partial class Program
{
}