using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberReferanceConfiguration:IEntityTypeConfiguration<MemberReferance>
{
    public void Configure(EntityTypeBuilder<MemberReferance> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.ReferanceName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.ReferanceSurname).IsRequired().HasMaxLength(50);
        builder.Property(i => i.ReferancePhone).IsRequired().HasMaxLength(20);
        builder.Property(i => i.ReferanceProf).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberReferances).
            HasForeignKey(i => i.MemberId);
    }
}