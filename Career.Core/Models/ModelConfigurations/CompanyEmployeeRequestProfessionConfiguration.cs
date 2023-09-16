using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class CompanyEmployeeRequestProfessionConfiguration:IEntityTypeConfiguration<CompanyEmployeeRequestProfession>
{
    public void Configure(EntityTypeBuilder<CompanyEmployeeRequestProfession> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.Property(i => i.ProfessionId).IsRequired();
        builder.Property(i => i.CompanyRequestId).IsRequired();
        builder.HasOne<Profession>(i => i.Profession).WithMany(i => i.CompanyEmployeeRequestProfessions).
            HasForeignKey(i => i.ProfessionId);
        builder.HasOne<CompanyEmployeeRequest>(i => i.CompanyEmployeeRequest).WithMany(i => i.CompanyEmployeeRequestProfessions).
            HasForeignKey(i => i.CompanyRequestId);
    }
}