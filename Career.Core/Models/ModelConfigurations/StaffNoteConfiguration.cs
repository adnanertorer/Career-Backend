using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Career.Core.Models.ModelConfigurations;

public class StaffNoteConfiguration:IEntityTypeConfiguration<StaffNote>
{
    public void Configure(EntityTypeBuilder<StaffNote> builder)
    {
         builder.HasKey(i => i.Id);
         builder.Property(i => i.MemberId).IsRequired();
         builder.Property(i => i.Note).IsRequired().HasMaxLength(250);
         builder.Property(i => i.NoteFile).HasMaxLength(50);
         builder.Property(i => i.CreatedAt).IsRequired();
         builder.Property(i => i.CreatedBy).IsRequired();
         builder.HasOne<Member>(i => i.Member).WithMany(i => i.StaffNotes).
             HasForeignKey(i => i.MemberId);
    }
}