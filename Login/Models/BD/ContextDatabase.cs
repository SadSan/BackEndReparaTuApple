using Microsoft.EntityFrameworkCore;

namespace Login.Models.BD
{
    public class ContextDatabase : DbContext, IContextDatabase
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
        }

        public DbSet<usuarios> usuarios { get; set; }

        public DbSet<customers> customers { get; set; }
    }
}
