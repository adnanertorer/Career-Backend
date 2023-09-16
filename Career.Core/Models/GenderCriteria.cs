namespace Career.Core.Models;

public class GenderCriteria:BaseModel
{
    public string GenderCriteriaName { get; set; } = null!;
    
    public ICollection<CompanyEmployeeRequest> CompanyEmployeeRequests { get; set; }
}