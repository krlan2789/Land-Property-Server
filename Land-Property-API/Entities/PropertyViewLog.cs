using System.ComponentModel.DataAnnotations;

namespace Land_Property.API.Entities;

public class PropertyViewLog
{
    [Key]
    public int Id { get; set; }

    public int PropertyId { get; set; }
    public Property? Property { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }

    public DateTime CreatedAt { get; set; }

    public PropertyViewLog()
    {
        CreatedAt = DateTime.Now;
    }
}
