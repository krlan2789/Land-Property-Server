using System.Numerics;
using Land_Property.API.Entities;

namespace Land_Property.API.Dtos;

public record class ResponsePropertyDto
(
    string Title,
    string Slug,
    string Address,
    float BuildingArea,
    Vector2 LandArea,
    byte Bedroom,
    byte Bathroom,
    byte Floor,
    ulong Price,
    string? Description,
    string[]? Images,
    User? User,
    PropertyType? BuildingType,
    AdvertisementType? AdvertisementType
);