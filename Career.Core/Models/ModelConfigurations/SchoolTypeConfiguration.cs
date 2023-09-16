using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class SchoolTypeConfiguration : IEntityTypeConfiguration<SchoolType>
{
    public void Configure(EntityTypeBuilder<SchoolType> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.TypeName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}