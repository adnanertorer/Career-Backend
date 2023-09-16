using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class AgeCriteriaConfiguration:IEntityTypeConfiguration<AgeCriteria>
{
    public void Configure(EntityTypeBuilder<AgeCriteria> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.AgeRangeName).IsRequired().HasMaxLength(20);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}