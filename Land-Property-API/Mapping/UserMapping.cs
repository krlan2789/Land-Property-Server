using Land_Property.API.Dtos;
using Land_Property.API.Entities;
using Land_Property.API.Helper;

namespace Land_Property.API.Mapping;

public static class UserMapping
{
    public static User ToEntity(this RegisterUserDto dto)
    {
        return new User
        {
            Name = dto.Name,
            Email = dto.Email,
            PasswordHash = dto.Password.Hash(),
            PhoneNumber = dto.PhoneNumber,
            Address = dto.Address,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }

    public static ResponseUserDto ToResponseDto(this User user)
    {
        return new ResponseUserDto
        (
            user.Name,
            user.Email,
            user.PhoneNumber,
            user.Address
        );
    }

    public static bool VerifyPassword(this User user, string password)
    {
        return password.VerifyHashed(user.PasswordHash);
    }
}
