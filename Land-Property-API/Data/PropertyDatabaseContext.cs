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

        // Users Table
        modelBuilder.Entity<User>()
            .HasIndex(e => e.Email)
            .IsUnique();
        modelBuilder.Entity<User>()
            .HasMany(u => u.Properties)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
        modelBuilder.Entity<User>()
            .Property(e => e.CreatedAt)
            .HasDefaultValueSql("GETDATE()");
        modelBuilder.Entity<User>()
            .Property(e => e.UpdatedAt)
            .HasDefaultValueSql("GETDATE()");

        // Properties Table
        modelBuilder.Entity<Property>()
            .HasIndex(e => e.Slug)
            .IsUnique();
        modelBuilder.Entity<Property>()
            .HasOne(p => p.User)
            .WithMany(u => u.Properties)
            .HasForeignKey(p => p.UserId);
        modelBuilder.Entity<Property>()
            .HasOne(p => p.BuildingType)
            .WithMany(pt => pt.Properties)
            .HasForeignKey(p => p.BuildingTypeId);
        modelBuilder.Entity<Property>()
            .HasOne(p => p.AdvertisementType)
            .WithMany(at => at.Properties)
            .HasForeignKey(p => p.AdvertisementTypeId);
        modelBuilder.Entity<Property>()
            .Property(e => e.BuildingArea)
            .HasConversion<double>();
        modelBuilder.Entity<Property>()
            .Property(e => e.LandArea)
            .HasConversion(converter);
        modelBuilder.Entity<Property>()
            .Property(e => e.CreatedAt)
            .HasDefaultValueSql("GETDATE()");
        modelBuilder.Entity<Property>()
            .Property(e => e.UpdatedAt)
            .HasDefaultValueSql("GETDATE()");

        // PropertyType Table
        modelBuilder.Entity<PropertyType>()
            .HasIndex(e => e.Slug)
            .IsUnique();
        modelBuilder.Entity<PropertyType>()
            .HasMany(pt => pt.Properties)
            .WithOne(p => p.BuildingType)
            .HasForeignKey(p => p.BuildingTypeId);
        modelBuilder.Entity<PropertyType>()
            .Property(e => e.CreatedAt)
            .HasDefaultValueSql("GETDATE()");
        modelBuilder.Entity<PropertyType>()
            .Property(e => e.UpdatedAt)
            .HasDefaultValueSql("GETDATE()");
        modelBuilder.Entity<PropertyType>().HasData(
            new PropertyType { Id = 1, Name = "House", Slug = "house" },
            new PropertyType { Id = 2, Name = "Apartment", Slug = "apartment" },
            new PropertyType { Id = 3, Name = "Guesthouse", Slug = "guesthouse" },
            new PropertyType { Id = 4, Name = "Warehouse", Slug = "warehouse" },
            new PropertyType { Id = 5, Name = "Commercial", Slug = "commercial" }
        );

        // AdvertisementType Table
        modelBuilder.Entity<AdvertisementType>()
            .HasIndex(e => e.Slug)
            .IsUnique();
        modelBuilder.Entity<AdvertisementType>()
            .HasMany(at => at.Properties)
            .WithOne(p => p.AdvertisementType)
            .HasForeignKey(p => p.AdvertisementTypeId);
        modelBuilder.Entity<AdvertisementType>()
            .Property(e => e.CreatedAt)
            .HasDefaultValueSql("GETDATE()");
        modelBuilder.Entity<AdvertisementType>()
            .Property(e => e.UpdatedAt)
            .HasDefaultValueSql("GETDATE()");
        modelBuilder.Entity<AdvertisementType>().HasData(
            new AdvertisementType { Id = 1, Name = "Rent", Slug = "rent" },
            new AdvertisementType { Id = 2, Name = "Sell", Slug = "sell" },
            new AdvertisementType { Id = 3, Name = "Credit", Slug = "credit" }
        );

        // UserSessionLog Table
        modelBuilder.Entity<UserSessionLog>()
            .Property(e => e.CreatedAt)
            .HasDefaultValueSql("GETDATE()");

        // PropertyViewLog Table
        modelBuilder.Entity<PropertyViewLog>()
            .Property(e => e.CreatedAt)
            .HasDefaultValueSql("GETDATE()");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
