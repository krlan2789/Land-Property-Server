using Land_Property.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Seeders;

public static class DatabaseSeeder
{
    public static async Task Seed(IServiceProvider serviceProvider)
    {
        using var context = new PropertyDatabaseContext(serviceProvider.GetRequiredService<DbContextOptions<PropertyDatabaseContext>>());
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.EnsureDeleted();
            await context.Database.MigrateAsync();
        }
        await UserSeeder.Seed(context);
        await PropertySeeder.Seed(context);
    }
}
