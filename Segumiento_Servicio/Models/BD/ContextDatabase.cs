using Microsoft.EntityFrameworkCore;

namespace Segumiento_Servicio.Models.BD
{
    public class ContextDatabase : DbContext, IContextDatabase
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
        }

        public DbSet<seguimiento> seguimiento { get; set; }
    }
}
