namespace Career.Core.Models;

public class Category : BaseModel
{
    public string CategoryName { get; set; } = null!;
    
    public ICollection<CompanyEmployeeRequest> CompanyEmployeeRequests { get; set; }
}