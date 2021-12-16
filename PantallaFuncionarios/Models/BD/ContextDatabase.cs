using Microsoft.EntityFrameworkCore;

namespace PantallaFuncionarios.Models.BD
{
    public class ContextDatabase : DbContext, IContextDatabase
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
        }

        public DbSet<Seguimiento> seguimiento { get; set; }
    }
}
