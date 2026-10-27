namespace Arishma.Auth.Domain;
public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Email { get; set; } = "";
    public string DisplayName { get; set; } = "";
}
