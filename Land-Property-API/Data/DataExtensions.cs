using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        // using var scope = app.Services.CreateScope();
        // await scope.ServiceProvider.GetRequiredService<PropertyDatabaseContext>().Database.MigrateAsync();

        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var dbContext = services.GetRequiredService<PropertyDatabaseContext>();
        try
        {
            var logger = services.GetRequiredService<ILogger<PropertyDatabaseContext>>();
            logger.LogInformation("Applying database migrations...");
            await dbContext.Database.MigrateAsync();
            logger.LogInformation("Database migration completed successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Database migration failed: {ex.Message}");
        }
    }
}
