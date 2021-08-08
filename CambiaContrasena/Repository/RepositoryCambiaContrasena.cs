using CambiaContrasena.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CambiaContrasena.Repository
{
    public class RepositoryCambiaContrasena : IRepositoryCambiaContrasena
    {
        private readonly IContextDatabase _database;
        public RepositoryCambiaContrasena(IContextDatabase database)
        {
            _database = database;
        }

        public bool CambiaContrasenaCliente(customers customers)
        {
            _database.customers.Update(customers);
            _database.SaveChanges();
            return true;
        }

        public bool CambiaContrasenaUsuario(usuarios usuarios)
        {
            _database.usuarios.Update(usuarios);
            _database.SaveChanges();
            return true;
        }
    }
}
