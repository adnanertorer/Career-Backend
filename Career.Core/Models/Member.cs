using System.Collections;

namespace Career.Core.Models;

public class Member:BaseModel
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string PasswordSalt { get; set; }
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
    
    public City City { get; set; }
    public District District { get; set; }
    
    public ICollection<MemberJobRequest> MemberJobRequests { get; set; }
    public ICollection<MemberCall> MemberCalls { get; set; }
    public ICollection<MemberCompetence> MemberCompetences { get; set; }
    public ICollection<MemberDocument> MemberDocuments { get; set; }
    public ICollection<MemberDriverLicense> MemberDriverLicenses { get; set; }
    public ICollection<MemberEducation> MemberEducations { get; set; }
    public ICollection<MemberExperience> MemberExperiences { get; set; }
    public ICollection<MemberReferance> MemberReferances { get; set; }
    public ICollection<MemberPersonalInformation> MemberPersonalInformations { get; set; }
    public ICollection<StaffNote> StaffNotes { get; set; }
}