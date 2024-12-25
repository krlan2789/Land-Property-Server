using Land_Property.API.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add Database Context services to the container
var connString = builder.Configuration.GetConnectionString("DatabaseConnection");
builder.Services.AddDbContext<PropertyDatabaseContext>(option =>
{
    option.UseSqlServer(connString);
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    string openApiRoute = "/docs/{documentName}/openapi.json";
    // Register the endpoint for viewing the OpenAPI
    app.MapOpenApi(openApiRoute);
    app.MapScalarApiReference(options =>
    {
        string scalarApiRoute = "/docs/{documentName}";
        options
            .WithTitle("Land Property - REST API")
            .WithTheme(ScalarTheme.BluePlanet)
            .WithEndpointPrefix(scalarApiRoute)
            .WithOpenApiRoutePattern(openApiRoute)
            ;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Migrate the database
if (app.Environment.IsDevelopment())
{
    await app.MigrateDbAsync();
}

app.Run();
