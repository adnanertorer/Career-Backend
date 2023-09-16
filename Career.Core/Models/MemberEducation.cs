namespace Career.Core.Models;

public class MemberEducation : BaseModel
{
    public int MemberId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? FinishDate { get; set; }
    public bool? IsResume { get; set; }
    public bool? IsLeave { get; set; }
    public int? EducationStatusId { get; set; }
    public string? DiplomaGrade { get; set; }
    public int SchoolTypeId { get; set; }
    public string SchoolName { get; set; } = null!;
    public int? CityId { get; set; }
    public string? Faculty { get; set; }
    public string? SchoolSection { get; set; }
    public string? Description { get; set; }
    
    public Member Member { get; set; }
    public SchoolType SchoolType { get; set; }
    public EducationStatus? EducationStatus { get; set; }
    public City? City { get; set; }
}