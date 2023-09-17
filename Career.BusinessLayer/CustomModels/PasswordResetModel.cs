namespace Career.BusinessLayer.CustomModels;

public class PasswordResetModel
{
    public string NewPassword { get; set; } = null!;
    public string OldPassword { get; set; } = null!;
    public string PasswordAgain { get; set; } = null!;
}