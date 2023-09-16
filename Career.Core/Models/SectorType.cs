namespace Career.Core.Models;

public class SectorType:BaseModel
{
    public string TypeName { get; set; } = null!;
    
    public ICollection<MemberExperience> MemberExperiences { get; set; }
}