using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Entities;

[Index(nameof(Slug), IsUnique = true)]
public class Property
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public required string Title { get; set; }

    [Required, MaxLength(512)]
    public required string Slug { get; set; }

    [Required]
    public required string Address { get; set; }

    [Required]
    public required float BuildingArea { get; set; }

    [Required, TypeConverter(typeof(Vector2))]
    public required Vector2 LandArea { get; set; }

    public byte Bedroom { get; set; }

    public byte Bathroom { get; set; }

    public byte Floor { get; set; }

    public ulong Price { get; set; }

    public string? Description { get; set; }

    [TypeConverter(typeof(string[]))]
    public IEnumerable<string>? Images { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }

    public int BuildingTypeId { get; set; }
    public PropertyType? BuildingType { get; set; }

    public int AdvertisementTypeId { get; set; }
    public AdvertisementType? AdvertisementType { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Property()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}