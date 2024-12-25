namespace Land_Property.API.Dtos;

public record class ResponseUserDto
(
    string Name,
    string Email,
    string PhoneNumber,
    string? Address
);
