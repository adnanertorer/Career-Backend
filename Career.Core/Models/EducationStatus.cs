namespace Career.Core.Models;

public class EducationStatus:BaseModel
{
    public string TypeName { get; set; } = null!;
    
    public ICollection<MemberEducation> MemberEducations { get; set; }
}