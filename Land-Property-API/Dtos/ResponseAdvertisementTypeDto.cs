namespace Land_Property.API.Dtos;

public record class ResponseAdvertisementTypeDto
(
    string Name,
    string Slug,
    string? Description
);