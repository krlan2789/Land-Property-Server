using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Entities;

[Index(nameof(Code), IsUnique = true)]
public class PropertyType
{
    public int Id { get; set; }

    [Required, MaxLength(64)]
    public required string Code { get; set; }

    [Required, MaxLength(64)]
    public required string Name { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
