namespace Land_Property.API.Dtos;

public record class ResponsePropertyTypeDto
(
    string Name,
    string Slug,
    string? Description
);