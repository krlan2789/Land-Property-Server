using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Land_Property.API.Entities;

[Index(nameof(Slug), IsUnique = true)]
public class PropertyType
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(64)]
    public required string Slug { get; set; }

    [Required, MaxLength(64)]
    public required string Name { get; set; }

    public string? Description { get; set; }
    public ICollection<Property>? Properties { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public PropertyType()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}
