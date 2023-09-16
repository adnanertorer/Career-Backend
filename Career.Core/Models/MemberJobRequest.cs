namespace Career.Core.Models;

public class MemberJobRequest:BaseModel
{
    public int CompanyRequestId { get; set; }
    public int MemberId { get; set; }
    public string? StaffNote { get; set; }
    public int RequestStatus { get; set; }
    public DateTime? AddedDate { get; set; }
    public int? AddedBy { get; set; }
    public int CompanyId { get; set; }
    public int? ApproveCriteria { get; set; }
    public int? IsSufficientPerson { get; set; }
    
    public CompanyEmployeeRequest CompanyEmployeeRequest { get; set; }
    public Member Member { get; set; }
}