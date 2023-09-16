namespace Career.Core.Models;

public class MemberReferance:BaseModel
{
    public int MemberId { get; set; }
    public string ReferanceName { get; set; } = null!;
    public string ReferanceSurname { get; set; } = null!;
    public string ReferancePhone { get; set; } = null!;
    public bool? IsApprove { get; set; } 
    public string ReferanceProf { get; set; } = null!;
    
    public Member Member { get; set; }
}