using System.ComponentModel.DataAnnotations;

namespace Land_Property.API.Dtos;

public record class RegisterUserDto
(
    [Required, StringLength(255)] string Name,
    [Required, StringLength(128)] string Email,
    [Required, StringLength(64)] string Password,
    [Required, StringLength(32)] string PhoneNumber,
    string? Address
);
