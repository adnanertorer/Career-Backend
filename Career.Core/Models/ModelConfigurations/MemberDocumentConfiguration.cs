using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class MemberDocumentConfiguration:IEntityTypeConfiguration<MemberDocument>
{
    public void Configure(EntityTypeBuilder<MemberDocument> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.MemberId).IsRequired();
        builder.Property(i => i.DocumentTypeId).IsRequired();
        builder.Property(i => i.DocumentFileName).IsRequired().HasMaxLength(50);
        builder.Property(i => i.CreatedAt).IsRequired();
        builder.Property(i => i.CreatedBy).IsRequired();
        builder.HasOne<Member>(i => i.Member).WithMany(i => i.MemberDocuments).
            HasForeignKey(i => i.MemberId);
        builder.HasOne<DocumentType>(i => i.DocumentType).WithMany(i => i.MemberDocuments).
            HasForeignKey(i => i.DocumentTypeId);
    }
}