using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberJobRequestConfiguration:IEntityTypeConfiguration<MemberJobRequest>
{
    public void Configure(EntityTypeBuilder<MemberJobRequest> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.CompanyId).IsRequired();
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.CompanyRequestId).IsRequired();
        builder.Property(i => i.RequestStatus).IsRequired();
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<CompanyEmployeeRequest>(i => i.CompanyEmployeeRequest).WithMany(i => i.MemberJobRequests).
            HasForeignKey(i => i.CompanyRequestId);
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberJobRequests).
            HasForeignKey(i => i.MemberId);
    }
}