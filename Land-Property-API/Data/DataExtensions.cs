using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        await scope.ServiceProvider.GetRequiredService<PropertyDatabaseContext>().Database.MigrateAsync();
    }
}
