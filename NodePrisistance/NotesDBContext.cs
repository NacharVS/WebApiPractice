using Microsoft.EntityFrameworkCore;
using NotesApplication.Interfaces;
using NotesDomain;
using NodePrisistance.EntityTypeConfigurations;

namespace NodePrisistance
{
    public class NotesDBContext : DbContext, INotesDBContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDBContext(DbContextOptions<NotesDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
