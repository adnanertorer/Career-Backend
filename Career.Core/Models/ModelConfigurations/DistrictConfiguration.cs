using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class DistrictConfiguration : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.DistrictName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CityId).IsRequired();
        builder.HasOne<City>(i => i.City).WithMany(i => i.Districts).
            HasForeignKey(i => i.CityId);
    }
}