namespace Career.Core.Models;

public class AgeCriteria:BaseModel
{
    public string AgeRangeName { get; set; } = null!;
    public int? MinAge { get; set; }
    public int? MaxAge { get; set; }
    
    public ICollection<CompanyEmployeeRequest> CompanyEmployeeRequests { get; set; }
}