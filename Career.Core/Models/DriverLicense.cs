namespace Career.Core.Models;

public class DriverLicense:BaseModel
{
    public string LicenseName { get; set; } = null!;
    
    public ICollection<MemberDriverLicense> MemberDriverLicenses { get; set; }
}