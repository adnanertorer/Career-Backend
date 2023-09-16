namespace Career.Core.Models;

public class GenderType:BaseModel
{
    public string GenderName { get; set; } = null!;
    
    public ICollection<MemberPersonalInformation> MemberPersonalInformations { get; set; }
}