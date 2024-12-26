using System.Numerics;
using Land_Property.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;

namespace Land_Property.API.Data;

public class PropertyDatabaseContext(DbContextOptions<PropertyDatabaseContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();

    public DbSet<Property> Properties => Set<Property>();

    public DbSet<PropertyType> PropertyTypes => Set<PropertyType>();

    public DbSet<AdvertisementType> AdvertisementTypes => Set<AdvertisementType>();

    public DbSet<UserSessionLog> UserSessionLogs => Set<UserSessionLog>();

    public DbSet<PropertyViewLog> PropertyViewLogs => Set<PropertyViewLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var converter = new ValueConverter<Vector2, string>(
            v => JsonConvert.SerializeObject(v),
            v => JsonConvert.DeserializeObject<Vector2>(v)
        );

        // Properties Table
        modelBuilder.Entity<Property>()
            .Property(e => e.LandArea)
            .HasConversion(converter);

        // Users Table
        modelBuilder.Entity<User>()
            .HasIndex(e => e.Email)
            .IsUnique();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
