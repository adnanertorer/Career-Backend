using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberCompetenceConfiguration:IEntityTypeConfiguration<MemberCompetence>
{
    public void Configure(EntityTypeBuilder<MemberCompetence> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.CompetenceName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberCompetences).
            HasForeignKey(i => i.MemberId);
    }
}