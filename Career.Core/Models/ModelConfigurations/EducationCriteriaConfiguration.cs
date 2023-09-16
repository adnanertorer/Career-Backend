using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class EducationCriteriaConfiguration:IEntityTypeConfiguration<EducationCriteria>
{
    public void Configure(EntityTypeBuilder<EducationCriteria> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.EducationCriteriaName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}