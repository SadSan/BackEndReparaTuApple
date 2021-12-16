using Login.Models.BD;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Repository
{
    public class RepositoryLogin : IRepositoryLogin
    {
        private readonly IContextDatabase _database;

        public RepositoryLogin(IContextDatabase database)
        {
            _database = database;
        }

        public IEnumerable<usuarios> GETALL()
        {
            return _database.usuarios.AsNoTracking().ToList();
        }

        public IEnumerable<customers> GETALLC()
        {
            return _database.customers.AsNoTracking().ToList();
        }
    }
}
