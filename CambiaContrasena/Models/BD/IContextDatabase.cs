using Microsoft.EntityFrameworkCore;

namespace CambiaContrasena.Models.BD
{
    public interface IContextDatabase
    {
        DbSet<customers> customers { get; set;}
        DbSet<usuarios> usuarios { get; set; }

        int SaveChanges();
    }
}
