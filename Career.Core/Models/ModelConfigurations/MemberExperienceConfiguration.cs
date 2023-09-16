using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberExperienceConfiguration:IEntityTypeConfiguration<MemberExperience>
{
    public void Configure(EntityTypeBuilder<MemberExperience> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.CompanyName).IsRequired().HasMaxLength(100);
        builder.Property(i => i.Position).IsRequired().HasMaxLength(150);
        builder.Property(i => i.StartDate).IsRequired();
        builder.Property(i => i.SectorId).IsRequired();
        builder.Property(i => i.BusinessAreaId).IsRequired();
        builder.Property(i => i.WorkingTypeId).IsRequired();
        builder.Property(i => i.CityId).IsRequired();
        builder.Property(i => i.Description).HasMaxLength(250);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberExperiences).
            HasForeignKey(i => i.MemberId);
        builder.HasOne<SectorType>(i => i.SectorType).WithMany(i => i.MemberExperiences).
            HasForeignKey(i => i.SectorId);
        builder.HasOne<BusinessArea>(i => i.BusinessArea).WithMany(i => i.MemberExperiences).
            HasForeignKey(i => i.BusinessAreaId);
        builder.HasOne<WorkingType>(i => i.WorkingType).WithMany(i => i.MemberExperiences).
            HasForeignKey(i => i.WorkingTypeId);
        builder.HasOne<City>(i => i.City).WithMany(i => i.MemberExperiences).
            HasForeignKey(i => i.CityId);
    }
}