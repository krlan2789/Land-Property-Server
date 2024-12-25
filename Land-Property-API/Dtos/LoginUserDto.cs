using System.ComponentModel.DataAnnotations;

namespace Land_Property.API.Dtos;

public record class LoginUserDto
(
    [Required, StringLength(128)] string Email,
    [Required, StringLength(64)] string Password
);