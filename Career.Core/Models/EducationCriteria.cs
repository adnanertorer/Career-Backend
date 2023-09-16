namespace Career.Core.Models;

public class EducationCriteria:BaseModel
{
    public string EducationCriteriaName { get; set; } = null!;
    
    public ICollection<CompanyEmployeeRequest> CompanyEmployeeRequests { get; set; }

}