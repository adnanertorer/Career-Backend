namespace Career.Core.Dtos;

public class BaseDto
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ChangedAt { get; set; }
    public int CreatedBy { get; set; }
    public int? ChangedBy { get; set; }
}