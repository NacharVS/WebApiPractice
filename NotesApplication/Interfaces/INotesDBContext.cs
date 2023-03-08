using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotesDomain;
namespace NotesApplication.Interfaces
{
    public interface INotesDBContext
    {
        DbSet<Note> Notes { get; set; }
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
