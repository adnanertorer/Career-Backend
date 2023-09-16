namespace Career.Core.Models;

public class Profession:BaseModel
{
    public string ProfessionName { get; set; } = null!;
    public string ProfessionCode { get; set; } = null!;
    
    public ICollection<CompanyEmployeeRequestProfession> CompanyEmployeeRequestProfessions { get; set; }
}