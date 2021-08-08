using Microsoft.EntityFrameworkCore;

namespace CambiaContrasena.Models.BD
{
    public class ContextDatabase : DbContext, IContextDatabase
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
        }

        public DbSet<customers> customers { get; set; }
        public DbSet<usuarios> usuarios { get ; set; }
    }
}
