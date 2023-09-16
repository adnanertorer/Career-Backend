using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class DriverLicanseConfiguration : IEntityTypeConfiguration<DriverLicanse>
{
    public void Configure(EntityTypeBuilder<DriverLicanse> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.LicenseName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}