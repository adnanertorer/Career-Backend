using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class GenderCriteriaConfiguration : IEntityTypeConfiguration<GenderCriteria>
{
    public void Configure(EntityTypeBuilder<GenderCriteria> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.GenderCriteriaName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}