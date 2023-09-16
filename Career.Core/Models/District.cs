namespace Career.Core.Models;

public class District:BaseModel
{
    public string DistrictName { get; set; } = null!;
    public int CityId { get; set; }

    public City City { get; set; }
    public ICollection<Member> Members { get; set; }
}