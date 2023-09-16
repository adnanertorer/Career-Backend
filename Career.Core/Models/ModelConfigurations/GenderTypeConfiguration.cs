using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class GenderTypeConfiguration:IEntityTypeConfiguration<GenderType>
{
    public void Configure(EntityTypeBuilder<GenderType> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.GenderName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}