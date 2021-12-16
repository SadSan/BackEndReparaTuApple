using Microsoft.EntityFrameworkCore;


namespace Login.Models.BD
{
    public interface IContextDatabase
    {
        DbSet<usuarios> usuarios { get; set;}
        DbSet<customers> customers { get; set; }
        int SaveChanges();
    }
}
