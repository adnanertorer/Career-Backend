namespace Career.Core.Models;

public class AdminUser:BaseModel
{
    public string Email { get; set; } = null!;
    public string Password { get; set; }= null!;
    public string Name { get; set; }= null!;
    public string Surname { get; set; }= null!;
    public bool IsActive { get; set; } 
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }
    public string Phone { get; set; } = null!;
    public string? SmsCode { get; set; }
}