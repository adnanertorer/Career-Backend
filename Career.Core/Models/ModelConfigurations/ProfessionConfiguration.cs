using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class ProfessionConfiguration:IEntityTypeConfiguration<Profession>
{
    public void Configure(EntityTypeBuilder<Profession> builder)
    {
         builder.HasKey(i => i.Id);
         builder.Property(i => i.ProfessionCode).IsRequired().HasMaxLength(10);
         builder.Property(i => i.ProfessionName).IsRequired().HasMaxLength(50);
         builder.Property(i => i.CreatedAt).IsRequired();
         builder.Property(i => i.CreatedBy).IsRequired();
    }
}