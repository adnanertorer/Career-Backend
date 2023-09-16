namespace Career.Core.Models;

public class MemberExperience:BaseModel
{
    public int MemberId { get; set; }
    public string CompanyName { get; set; } = null!;
    public string Position { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime? FinishDate { get; set; }
    public int SectorId { get; set; }
    public int BusinessAreaId { get; set; }
    public int WorkingTypeId { get; set; }
    public int CityId { get; set; }
    public string? Description { get; set; }
    
    public Member Member { get; set; }
    public SectorType SectorType { get; set; }
    public BusinessArea BusinessArea { get; set; }
    public WorkingType WorkingType { get; set; }
    public City City { get; set; }
}