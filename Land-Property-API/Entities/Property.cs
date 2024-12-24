using System.Numerics;
using Land_Property_API.Data;

namespace Land_Property_API.Entities;

public class Property
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required bool AvailableRent { get; set; }
    public required string Address { get; set; }
    public required float BuildingArea { get; set; }
    public required Vector2 LandArea { get; set; }
    public int Bedroom { get; set; }
    public int Bathroom { get; set; }
    public int Floor { get; set; }
    public int BuildingTypeId { get; set; }
    public PropertyType? BuildingType { get; set; }
    public int AdsTypeId { get; set; }

    public AdvertisementType? AdsType { get; set; }
    public IEnumerable<string>? Images { get; set; }
    public string? Description { get; set; }

    public long Price { get; set; }
    public required string PhoneNumber { get; set; }
}