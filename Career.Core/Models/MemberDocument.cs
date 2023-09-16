namespace Career.Core.Models;

public class MemberDocument:BaseModel
{
    public int DocumentTypeId { get; set; }
    public int MemberId { get; set; }
    public DateTime? ValidDate { get; set; }
    public string DocumentFileName { get; set; } = null!;
    public string? DocumentFilePatch { get; set; }
    
    public DocumentType DocumentType { get; set; }
    public Member Member { get; set; }
}