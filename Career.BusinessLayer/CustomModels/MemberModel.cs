namespace Career.BusinessLayer.CustomModels;

public class MemberModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string PasswordSalt { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }
    public int CityId { get; set; }
    public int DistrictId { get; set; }
    public string Address { get; set; } = null!;
    public string? SummaryText { get; set; }
    public string? SmsCode { get; set; }
    public string? ProfileImage { get; set; }
    public int Graduation { get; set; }
    public bool? Attention { get; set; } = false;
    public bool? Preferential { get; set; } = false;
    public bool? IsBlocked { get; set; } = false;
    public int? BirthYear { get; set; }
    public DateTime BirthDate { get; set; }
}