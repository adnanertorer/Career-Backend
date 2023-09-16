using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberDriverLicenseConfiguration : IEntityTypeConfiguration<MemberDriverLicense>
{
    public void Configure(EntityTypeBuilder<MemberDriverLicense> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.LicenseId).IsRequired();
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberDriverLicenses).
            HasForeignKey(i => i.MemberId);
        builder.HasOne<DriverLicanse>(i => i.DriverLicanse).WithMany(i => i.MemberDriverLicenses).
            HasForeignKey(i => i.LicenseId);
    }
}