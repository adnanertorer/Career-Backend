using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberConfiguration:IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
         builder.HasKey(i => i.Id);
         builder.Property(i => i.Address).IsRequired().HasMaxLength(255);
         builder.Property(i => i.Phone).IsRequired().HasMaxLength(20);
         builder.Property(i => i.Password).IsRequired().HasMaxLength(64);
         builder.Property(i => i.PasswordSalt).HasMaxLength(64);
         builder.Property(i => i.Surname).IsRequired().HasMaxLength(50);
         builder.Property(i => i.Email).IsRequired().HasMaxLength(50);
         builder.Property(i => i.Graduation).IsRequired();
         builder.Property(i => i.Name).IsRequired().HasMaxLength(50);
         builder.Property(i => i.BirthDate).IsRequired();
         builder.Property(i => i.CityId).IsRequired();
         builder.Property(i => i.DistrictId).IsRequired();
         builder.Property(i => i.IsActive).IsRequired();
         builder.Property(i => i.CreatedAt).IsRequired();
         builder.Property(i => i.CreatedBy).IsRequired();
         builder.HasOne<City>(i => i.City).WithMany(i => i.Members).
             HasForeignKey(i => i.CityId);
         builder.HasOne<District>(i => i.District).WithMany(i => i.Members).
             HasForeignKey(i => i.DistrictId);
    }
}