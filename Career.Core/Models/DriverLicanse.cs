namespace Career.Core.Models;

public class DriverLicanse:BaseModel
{
    public string LicenseName { get; set; } = null!;
    
    public ICollection<MemberDriverLicense> MemberDriverLicenses { get; set; }
}