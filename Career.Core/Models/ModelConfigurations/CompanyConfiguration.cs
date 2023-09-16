using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.CompanyName).IsRequired().HasMaxLength(150);
        builder.Property(i => i.Address).IsRequired().HasMaxLength(250);
        builder.Property(i => i.Phone).IsRequired().HasMaxLength(20);
        builder.Property(i => i.AuthorizedPerson).IsRequired().HasMaxLength(150);
        builder.Property(i => i.IsActive).IsRequired();
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
    }
}