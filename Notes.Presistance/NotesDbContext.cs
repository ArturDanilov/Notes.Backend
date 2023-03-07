using Microsoft.EntityFrameworkCore;
using Notes.Aplication.Interfaces;
using Notes.Domain;
using Notes.Presistance.EntityTypeConfiguration;

namespace Notes.Presistance
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }

        //что делает метод OnModelCreating? Урок 3 "Entity Framework Core 5.0 - добавляем базу данных в проект" -> 9:00
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
