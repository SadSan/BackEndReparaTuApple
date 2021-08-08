using Microsoft.EntityFrameworkCore;

namespace Segumiento_Servicio.Models.BD
{
    public interface IContextDatabase
    {
        DbSet<Seguimiento> seguimiento { get; set;}
        int SaveChanges();
    }
}
