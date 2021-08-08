using ClientesReparatuApple.Models.BD;
using Microsoft.EntityFrameworkCore;

namespace Usuarios.Models.BD
{
    public class ContextDatabase : DbContext, IContextDatabase
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
        }

        public DbSet<customers> customers { get; set; }
    }
}
