using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Entities;

[Index(nameof(Email), IsUnique = true)]
public class User
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public required string Name { get; set; }

    [Required, MaxLength(128)]
    public required string Email { get; set; }

    [Required, MaxLength(255)]
    public required string PasswordHash { get; set; }

    [Required, MaxLength(32)]
    public required string PhoneNumber { get; set; }

    public string? Address { get; set; }
    public ICollection<Property>? Properties { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public User()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}
