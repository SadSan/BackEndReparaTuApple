using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Models.BD;

namespace cli.Models.BD
{
   public interface IContextDatabase
    {
        DbSet<usuarios> usuarios { get; set;}
        int SaveChanges();
    }
}
