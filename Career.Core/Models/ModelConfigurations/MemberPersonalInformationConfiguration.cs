using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberPersonalInformationConfiguration : IEntityTypeConfiguration<MemberPersonalInformation>
{
    public void Configure(EntityTypeBuilder<MemberPersonalInformation> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.GenderTypeId).IsRequired();
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberPersonalInformations).
            HasForeignKey(i => i.MemberId);
        builder.HasOne<GenderType>(i => i.GenderType).WithMany(i => i.MemberPersonalInformations).
            HasForeignKey(i => i.GenderTypeId);
    }
}