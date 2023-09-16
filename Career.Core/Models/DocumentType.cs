namespace Career.Core.Models;

public class DocumentType:BaseModel
{
    public string DocumentTypeName { get; set; } = null!;
    
    public ICollection<MemberDocument> MemberDocuments { get; set; }
}