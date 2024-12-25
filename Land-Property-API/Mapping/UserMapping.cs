using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Microsoft.AspNetCore.Identity;

namespace Land_Property.API.Mapping;

public static class UserMapping
{
    private static readonly PasswordHasher<object> passwordHasher = new();

    public static User ToEntity(this RegisterUserDto dto)
    {
        return new User
        {
            Name = dto.Name,
            Email = dto.Email,
            PasswordHash = dto.Password.HashPassword(),
            PhoneNumber = dto.PhoneNumber,
            Address = dto.Address,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }

    public static ResponseUserDto ToResponseDto(this User dto)
    {
        return new ResponseUserDto
        (
            dto.Name,
            dto.Email,
            dto.PhoneNumber,
            dto.Address
        );
    }

    public static string HashPassword(this string password)
    {
        return passwordHasher.HashPassword(new(), password);
    }

    public static bool VerifyPassword(this User user, string password)
    {
        return passwordHasher.VerifyHashedPassword(new(), user.PasswordHash, password) == PasswordVerificationResult.Success;
    }
}
