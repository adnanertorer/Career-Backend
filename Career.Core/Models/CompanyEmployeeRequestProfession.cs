namespace Career.Core.Models;

public class CompanyEmployeeRequestProfession:BaseModel
{
    public int ProfessionId { get; set; }
    public int CompanyRequestId { get; set; }
    
    public Profession Profession { get; set; }
    public CompanyEmployeeRequest CompanyEmployeeRequest { get; set; }
}