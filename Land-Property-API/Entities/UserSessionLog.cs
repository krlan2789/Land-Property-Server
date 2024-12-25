namespace Land_Property.API.Entities;

public class UserSessionLog
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public string? IpAddress { get; set; }
    public string? UserAgent { get; set; }
    public string? Action { get; set; }
    public DateTime CreatedAt { get; set; }
}
