using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Land_Property.API.Helper;

namespace Land_Property.API.Mapping;

public static class PropertyMapping
{
    public static Property ToEntity(this CreatePropertyDto dto, User user, PropertyType buildingType, AdvertisementType advertisementType)
    {
        string slug = SlugHelper.Create(dto.Title);
        return new Property
        {
            Title = dto.Title,
            Slug = slug,
            Description = dto.Description,
            Address = dto.Address,
            Price = dto.Price,
            LandArea = new(dto.LandAreaX, dto.LandAreaY),
            Bedroom = dto.Bedroom,
            Bathroom = dto.Bathroom,
            BuildingArea = dto.BuildingArea,
            Floor = dto.Floor,
            Images = dto.Images,
            User = user,
            BuildingType = buildingType,
            AdvertisementType = advertisementType,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }

    public static Property ToEntity(this UpdatePropertyDto dto, string slug, User user, PropertyType buildingType, AdvertisementType advertisementType)
    {
        return new Property
        {
            Slug = slug,
            Title = dto.Title,
            Description = dto.Description,
            Address = dto.Address,
            Price = dto.Price,
            LandArea = new(dto.LandAreaX, dto.LandAreaY),
            Bedroom = dto.Bedroom,
            Bathroom = dto.Bathroom,
            BuildingArea = dto.BuildingArea,
            Floor = dto.Floor,
            Images = dto.Images,
            User = user,
            BuildingType = buildingType,
            AdvertisementType = advertisementType,
            UpdatedAt = DateTime.Now
        };
    }

    public static bool ContainsKeyword(this Property dto, string keyword)
    {
        bool status = false;
        status |= dto.Title.Contains(keyword);
        status |= ("" + dto.Description).Contains(keyword);
        status |= dto.Address.Contains(keyword);
        return status;
    }

    public static ResponsePropertyDto ToResponseDto(this Property property)
    {
        return new ResponsePropertyDto
        (
            property.Title,
            property.Slug,
            property.Address,
            property.BuildingArea,
            property.LandArea,
            property.Bedroom,
            property.Bathroom,
            property.Floor,
            property.Price,
            property.Description,
            property.Images?.ToArray(),
            property.User,
            property.BuildingType,
            property.AdvertisementType
        );
    }

    public static ResponsePropertyDto[] ToResponseDto(this Property[] property)
    {
        return property.Select(property => property.ToResponseDto()).ToArray();
    }
}
