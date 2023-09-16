using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class BusinessAreaConfiguration:IEntityTypeConfiguration<BusinessArea>
{
    public void Configure(EntityTypeBuilder<BusinessArea> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.TypeName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}