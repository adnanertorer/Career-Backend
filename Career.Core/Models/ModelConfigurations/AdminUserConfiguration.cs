using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class AdminUserConfiguration:IEntityTypeConfiguration<AdminUser>
{
    public void Configure(EntityTypeBuilder<AdminUser> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Email).IsRequired().HasMaxLength(50);
        builder.Property(i => i.Name).IsRequired().HasMaxLength(50);
        builder.Property(i => i.Password).IsRequired().HasMaxLength(50);
        builder.Property(i => i.Phone).IsRequired().HasMaxLength(20);
        builder.Property(i => i.Surname).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.Property(i => i.IsActive).IsRequired();
    }
}