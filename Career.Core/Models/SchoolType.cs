namespace Career.Core.Models;

public class SchoolType:BaseModel
{
    public string TypeName { get; set; } = null!;
    
    public ICollection<MemberEducation> MemberEducations { get; set; }
}