namespace MiniCRM.Domain.Entities;

public class User
{
    public Guid CompanyId { get; set; } 
    public  Company Company  { get; set; } = null!;
    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

}
