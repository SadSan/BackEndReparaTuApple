using Microsoft.EntityFrameworkCore;

namespace Segumiento_Servicio.Models.BD
{
    public interface IContextDatabase
    {
        DbSet<seguimiento> seguimiento { get; set;}
        int SaveChanges();
    }
}
