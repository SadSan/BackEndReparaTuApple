using Microsoft.EntityFrameworkCore;

namespace PantallaFuncionarios.Models.BD
{
    public interface IContextDatabase
    {
        DbSet<Seguimiento> seguimiento { get; set;}
        int SaveChanges();
    }
}
