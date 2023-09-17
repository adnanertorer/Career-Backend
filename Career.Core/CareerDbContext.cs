using Career.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Career.Core;

public class CareerDbContext:DbContext
{
    public CareerDbContext(DbContextOptions<CareerDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<AdminUser> AdminUsers { get; set; }
    public DbSet<AgeCriteria> AgeCriteria { get; set; }
    public DbSet<BusinessArea> BusinessAreas { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<CompanyEmployeeRequest> CompanyEmployeeRequests { get; set; }
    public DbSet<CompanyEmployeeRequestProfession> CompanyEmployeeRequestProfessions { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<DriverLicense> DriverLicenses { get; set; }
    public DbSet<EducationCriteria> EducationCriteria { get; set; }
    public DbSet<EducationStatus> EducationStatuses { get; set; }
    public DbSet<GenderCriteria> GenderCriteria { get; set; }
    public DbSet<GenderType> GenderTypes { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MemberCall> MemberCalls { get; set; }
    public DbSet<MemberCompetence> MemberCompetences { get; set; }
    public DbSet<MemberDocument> MemberDocuments { get; set; }
    public DbSet<MemberDriverLicense> MemberDriverLicenses { get; set; }
    public DbSet<MemberEducation> MemberEducations { get; set; }
    public DbSet<MemberExperience> MemberExperiences { get; set; }
    public DbSet<MemberJobRequest> MemberJobRequests { get; set; }
    public DbSet<MemberPersonalInformation> MemberPersonalInformations { get; set; }
    public DbSet<MemberReferance> MemberReferances { get; set; }
    public DbSet<Profession> Professions { get; set; }
    public DbSet<SchoolType> SchoolTypes { get; set; }
    public DbSet<SectorType> SectorTypes { get; set; }
    public DbSet<StaffNote> StaffNotes { get; set; }
    public DbSet<WorkingType> WorkingTypes { get; set; }

}