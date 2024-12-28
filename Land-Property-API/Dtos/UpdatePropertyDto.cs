using System.Numerics;
using Land_Property.API.Entities;

namespace Land_Property.API.Dtos;

public record class UpdatePropertyDto
(
    string Title,
    string Slug,
    string Address,
    float BuildingArea,
    float LandAreaX,
    float LandAreaY,
    byte Bedroom,
    byte Bathroom,
    byte Floor,
    ulong Price,
    string? Description,
    string[]? Images,
    int BuildingTypeId,
    int AdvertisementTypeId
);