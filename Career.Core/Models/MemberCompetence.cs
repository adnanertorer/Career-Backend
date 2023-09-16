namespace Career.Core.Models;

public class MemberCompetence:BaseModel
{
    public string CompetenceName { get; set; } = null!;
    public int MemberId { get; set; }
    
    public Member Member { get; set; }
}