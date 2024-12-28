using System.Text;
using Land_Property.API.Data;
using Land_Property.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add Database Context services to the container
builder.Services
    .AddDbContext<PropertyDatabaseContext>(option =>
    {
        option.UseSqlServer("" + builder.Configuration.GetConnectionString("DefaultConnection"));
    });

// Add configuration to the container
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Add services to the container.
string tokenIssuer = "" + builder.Configuration["Jwt:Issuer"];
string tokenAudience = "" + builder.Configuration["Jwt:Audience"];
string secretKey = "" + builder.Configuration["Jwt:SecretKey"];
builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = tokenIssuer,
            ValidAudience = tokenAudience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
        };
    });
builder.Services
    .AddCors(options =>
    {
        options.AddPolicy("AllowSpecificOrigins", builder =>
        {
            builder
                .WithOrigins("http://localhost")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .WithHeaders("Content-Type", "Authorization");
        });
    });
builder.Services.AddSingleton(new TokenService(secretKey, tokenIssuer, tokenAudience));
builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("AllowSpecificOrigins");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// Migrate the database
if (app.Environment.IsDevelopment())
{
    // Register the endpoint for viewing the OpenAPI Documentation
    string openApiRoute = "/api/docs/{documentName}/openapi.json";
    app.MapOpenApi(openApiRoute);
    app.MapScalarApiReference(options =>
    {
        string scalarApiRoute = "/api/docs/{documentName}";
        options
            .WithTheme(ScalarTheme.BluePlanet)
            .WithEndpointPrefix(scalarApiRoute)
            .WithOpenApiRoutePattern(openApiRoute)
            .WithTitle("Land Property - REST API");
    });

    await app.MigrateDbAsync();
}

app.Run();
