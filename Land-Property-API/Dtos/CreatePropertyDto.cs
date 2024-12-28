using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Land_Property.API.Dtos;

public record class CreatePropertyDto(
    [Required, StringLength(255)] string Title,
    [Required, StringLength(255)] string Address,
    [Required] float BuildingArea,
    [Required] Vector2 LandArea,
    [Required] byte Bedroom,
    [Required] byte Bathroom,
    [Required] byte Floor,
    [Required] ulong Price,
    [StringLength(255)] string? Description,
    string[]? Images,
    [Required] int UserId,
    [Required] int BuildingTypeId,
    [Required] int AdvertisementTypeId
);
