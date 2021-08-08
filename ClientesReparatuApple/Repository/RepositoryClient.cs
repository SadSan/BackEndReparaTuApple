using ClientesReparatuApple.Models.BD;
using ClientesReparatuApple.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Usuarios.Models.BD;

namespace ClientesReparatuApple.Repository
{
    public class RepositoryClient : IRepositoryClient
    {
        private readonly IContextDatabase _database;
        public RepositoryClient(IContextDatabase database)
        {
            _database = database;
        }

        public bool CreateClient(customers customers)
        {
            _database.customers.Add(customers);
            _database.SaveChanges();
            return true;
        }

        public IEnumerable<customers> GETALL()
        {
            return _database.customers.AsNoTracking().ToList();
        }

        public bool UpdateClient(customers customers)
        {
            _database.customers.Add(customers);
            _database.SaveChanges();
            return true;
        }
    }
}