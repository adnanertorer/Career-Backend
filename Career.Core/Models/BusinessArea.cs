namespace Career.Core.Models;

public class BusinessArea:BaseModel
{
    public string TypeName { get; set; } = null!;
    
    public ICollection<MemberExperience> MemberExperiences { get; set; }
}