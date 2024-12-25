namespace Land_Property.API.Entities;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required string PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
