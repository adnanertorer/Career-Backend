namespace Career.Core.Models;

public class StaffNote:BaseModel
{
    public int MemberId { get; set; }
    public string Note { get; set; } = null!;
    public string? NoteFile { get; set; }
    
    public Member Member { get; set; }
}