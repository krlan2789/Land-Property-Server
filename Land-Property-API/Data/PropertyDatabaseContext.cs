using Land_Property.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Data;

public class PropertyDatabaseContext(DbContextOptions<PropertyDatabaseContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();

    public DbSet<Property> Properties => Set<Property>();

    public DbSet<PropertyType> PropertyTypes => Set<PropertyType>();

    public DbSet<AdvertisementType> AdvertisementTypes => Set<AdvertisementType>();

    public DbSet<UserSessionLog> UserSessionLogs => Set<UserSessionLog>();

    public DbSet<PropertyViewLog> PropertyViewLogs => Set<PropertyViewLog>();
}
