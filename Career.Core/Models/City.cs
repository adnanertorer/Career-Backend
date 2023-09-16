namespace Career.Core.Models;

public class City
{
    public int Id { get; set; }
    public string CityName { get; set; } = null!;
    
    public ICollection<Member> Members { get; set; }
    public ICollection<District> Districts { get; set; }
    public ICollection<MemberEducation> MemberEducations { get; set; }
    public ICollection<MemberExperience> MemberExperiences { get; set; }
}