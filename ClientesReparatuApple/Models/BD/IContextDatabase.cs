using ClientesReparatuApple.Models.BD;
using Microsoft.EntityFrameworkCore;

namespace Usuarios.Models.BD
{
    public interface IContextDatabase
    {
        DbSet<customers> customers { get; set;}
        int SaveChanges();
    }
}
