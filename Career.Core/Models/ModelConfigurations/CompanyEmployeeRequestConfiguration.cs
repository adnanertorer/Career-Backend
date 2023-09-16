using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class CompanyEmployeeRequestConfiguration : IEntityTypeConfiguration<CompanyEmployeeRequest>
{
    public void Configure(EntityTypeBuilder<CompanyEmployeeRequest> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Title).IsRequired().HasMaxLength(150);
        builder.Property(i => i.Description).IsRequired().HasMaxLength(250);
        builder.Property(i => i.IsActive).IsRequired();
        builder.Property(i => i.Deadline).IsRequired();
        builder.Property(i => i.CategoryId).IsRequired();
        builder.Property(i => i.CompanyId).IsRequired();
        builder.Property(i => i.ForConvict).IsRequired();
        builder.Property(i => i.ForHandicapped).IsRequired();
        builder.Property(i => i.IsOpen).IsRequired();
        builder.Property(i => i.WorkTypeId).IsRequired();
        builder.Property(i => i.AgeCrtId).IsRequired();
        builder.Property(i => i.EducationCrtId).IsRequired();
        builder.Property(i => i.GenderCrtId).IsRequired();
        builder.Property(i => i.IsEveryProf).IsRequired();
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<Category>(i => i.Category).WithMany(i => i.CompanyEmployeeRequests).
            HasForeignKey(i => i.CategoryId);
        builder.HasOne<Company>(i => i.Company).WithMany(i => i.CompanyEmployeeRequests).
            HasForeignKey(i => i.CompanyId);
        builder.HasOne<WorkingType>(i => i.WorkingType).WithMany(i => i.CompanyEmployeeRequests).
            HasForeignKey(i => i.WorkTypeId);
        builder.HasOne<AgeCriteria>(i => i.AgeCriteria).WithMany(i => i.CompanyEmployeeRequests).
            HasForeignKey(i => i.AgeCrtId);
        builder.HasOne<EducationCriteria>(i => i.EducationCriteria).WithMany(i => i.CompanyEmployeeRequests).
            HasForeignKey(i => i.EducationCrtId);
        builder.HasOne<GenderCriteria>(i => i.GenderCriteria).WithMany(i => i.CompanyEmployeeRequests).
            HasForeignKey(i => i.GenderCrtId);
    }
}