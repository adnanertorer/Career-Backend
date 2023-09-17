namespace Career.BusinessLayer.CustomModels;

public class LoginModel
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string? RefreshToken { get; set; }
}