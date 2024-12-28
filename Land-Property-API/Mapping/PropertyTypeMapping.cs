using System;
using Land_Property.API.Dtos;
using Land_Property.API.Entities;

namespace Land_Property.API.Mapping;

public static class PropertyTypeMapping
{
    public static ResponsePropertyTypeDto ToDto(this PropertyType propertyType)
    {
        return new ResponsePropertyTypeDto
        (
            propertyType.Name,
            propertyType.Slug,
            propertyType.Description
        );
    }
}
