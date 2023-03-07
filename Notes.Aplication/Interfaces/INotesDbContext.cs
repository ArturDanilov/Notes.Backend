using Notes.Domain;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Notes.Aplication.Interfaces
{
    public interface INotesDbContext
    {
        //DbSet представляет коллекцию сущностей, которые хранятся в базе данных
        DbSet<Note> Notes { get; set; }

        //Сохраняет все изменения контекста в базу данных
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
