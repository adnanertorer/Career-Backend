namespace Career.Core.Models;

public class MemberDriverLicense:BaseModel
{
    public int LicenseId { get; set; }
    public int MemberId { get; set; }
    
    public Member Member { get; set; }
    public DriverLicanse DriverLicanse { get; set; }
}