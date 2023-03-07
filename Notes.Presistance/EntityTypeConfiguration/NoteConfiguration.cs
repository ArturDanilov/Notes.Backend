using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Notes.Presistance.EntityTypeConfiguration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    { 
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n => n.Id);
            builder.HasIndex(n => n.Id).IsUnique();
            //builder.Property(n => n.Title).IsRequired();
            //builder.Property(n => n.Detalis).IsRequired();
            //builder.Property(n => n.CreationDate).IsRequired();
            //builder.Property(n => n.EditDate).IsRequired(false);
        }
    }
}
