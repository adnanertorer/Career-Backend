namespace Career.Core.Models;

public class MemberCall:BaseModel
{
    public int CompanyRequestId { get; set; }
    public int MemberId { get; set; }
    public string Message { get; set; } = null!;
    public DateTime ExamDate { get; set; }
    public TimeSpan ExamTime { get; set; }
    public int MessageStatus { get; set; }
    
    public CompanyEmployeeRequest CompanyEmployeeRequest { get; set; }
    public Member Member { get; set; }
}