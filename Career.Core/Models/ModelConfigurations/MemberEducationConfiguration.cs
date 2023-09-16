using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberEducationConfiguration:IEntityTypeConfiguration<MemberEducation>
{
    public void Configure(EntityTypeBuilder<MemberEducation> builder)
    {
       builder.HasKey(i => i.Id);
       builder.Property(i => i.MemberId).IsRequired();
       builder.Property(i => i.SchoolTypeId).IsRequired();
       builder.Property(i => i.StartDate).IsRequired();
       builder.Property(i => i.SchoolName).IsRequired().HasMaxLength(50);
       builder.Property(i => i.CreatedAt).IsRequired();
       builder.Property(i => i.CreatedBy).IsRequired();
       builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberEducations).
           HasForeignKey(i => i.MemberId);
       builder.HasOne<SchoolType>(i => i.SchoolType).WithMany(i => i.MemberEducations).
           HasForeignKey(i => i.SchoolTypeId);
    }
}