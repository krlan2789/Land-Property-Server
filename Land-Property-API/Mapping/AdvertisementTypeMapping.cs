using System;
using Land_Property.API.Dtos;
using Land_Property.API.Entities;

namespace Land_Property.API.Mapping;

public static class AdvertisementTypeMapping
{
    public static ResponseAdvertisementTypeDto ToDto(this AdvertisementType advertisementType)
    {
        return new ResponseAdvertisementTypeDto
        (
            advertisementType.Name,
            advertisementType.Slug,
            advertisementType.Description
        );
    }
}
