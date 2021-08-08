using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Models.BD;

namespace Usuarios.Repository
{
    public class RepositoryUsers : IRepositoryUsers
    {
        private readonly IContextDatabase _database;

        public RepositoryUsers(IContextDatabase database)
        {
             _database = database;
        }

        public bool Createusers(usuarios usuarios)
        {
            _database.usuarios.Add(usuarios);
            _database.SaveChanges();
            return true;
        }

        //public bool DeleteUsers(USERS USERS)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<usuarios> GETALL()
        {
            return _database.usuarios.AsNoTracking().ToList();
        }


        public bool UpdateUsers(usuarios usuarios)
        {
            _database.usuarios.Update(usuarios);
            _database.SaveChanges();
             return true;
        }
    }
}