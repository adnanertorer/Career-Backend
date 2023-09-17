using Career.Core.Models;

namespace Career.BusinessLayer.CustomModels;

public class CompanyEmployeeRequestModel
{
    public int CompanyId { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; } = null!;
    public int WorkTypeId { get; set; }
    public DateTime Deadline { get; set; }
    public int EducationCrtId { get; set; }
    public int GenderCrtId { get; set; }
    public int AgeCrtId { get; set; }
    public bool IsEveryProf { get; set; } = true;
    public string Description { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public bool ForConvict { get; set; } = false;
    public bool ForHandicapped { get; set; } = false;
    public bool IsOpen { get; set; } = true;
    
    
    public Company Company { get; set; }
    public Category Category { get; set; }
    public WorkingType WorkingType { get; set; }
    public AgeCriteria AgeCriteria { get; set; }
    public EducationCriteria EducationCriteria { get; set; }
    public GenderCriteria GenderCriteria { get; set; }
}