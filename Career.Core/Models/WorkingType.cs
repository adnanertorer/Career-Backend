namespace Career.Core.Models;

public class WorkingType:BaseModel
{
    public string TypeName { get; set; } = null!;
    
    public ICollection<CompanyEmployeeRequest> CompanyEmployeeRequests { get; set; }
    public ICollection<MemberExperience> MemberExperiences { get; set; }
}