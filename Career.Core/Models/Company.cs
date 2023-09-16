namespace Career.Core.Models;

public class Company:BaseModel
{
    public string CompanyName { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string AuthorizedPerson { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    
    public ICollection<CompanyEmployeeRequest> CompanyEmployeeRequests { get; set; }
}