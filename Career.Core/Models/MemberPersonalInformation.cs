namespace Career.Core.Models;

public class MemberPersonalInformation:BaseModel
{
    public int MemberId { get; set; }
    public int GenderTypeId { get; set; }
    public int? DrivingLicense { get; set; }
    public bool? Handicapped { get; set; } = false;
    public decimal? ExpectationSalary { get; set; }
    public int? MaritalStatus { get; set; }
    public string? BirthCity { get; set; }
    public bool? Convict { get; set; } = false;
    
    public Member Member { get; set; }
    public GenderType GenderType { get; set; }
    public DriverLicense? DriverLicense { get; set; }
    
}