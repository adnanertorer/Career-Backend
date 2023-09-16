using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberCallConfiguration : IEntityTypeConfiguration<MemberCall>
{
    public void Configure(EntityTypeBuilder<MemberCall> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.CompanyRequestId).IsRequired();
        builder.Property(i => i.Message).IsRequired();
        builder.Property(i => i.MessageStatus).IsRequired();
        builder.Property(i => i.ExamDate).IsRequired();
        builder.Property(i => i.ExamTime).IsRequired();
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<CompanyEmployeeRequest>(i => i.CompanyEmployeeRequest).WithMany(i => i.MemberCalls).
            HasForeignKey(i => i.CompanyRequestId);
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberCalls).
            HasForeignKey(i => i.MemberId);
    }
}