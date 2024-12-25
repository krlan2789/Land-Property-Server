using System.Numerics;

namespace Land_Property.API.Entities;

public class Property
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Address { get; set; }
    public required float BuildingArea { get; set; }
    public required Vector2 LandArea { get; set; }
    public byte Bedroom { get; set; }
    public byte Bathroom { get; set; }
    public byte Floor { get; set; }
    public ulong Price { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string>? Images { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public int BuildingTypeId { get; set; }
    public PropertyType? BuildingType { get; set; }
    public int AdvertisementTypeId { get; set; }
    public AdvertisementType? AdsType { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}