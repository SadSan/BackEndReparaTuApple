using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Models.BD;
using Usuarios.Repository;

namespace Usuarios.Service
{
    public class ServiceUsers : IServiceUsers
    {
        private readonly IRepositoryUsers _repositoryUsers;

        public ServiceUsers(IRepositoryUsers repositoryUsers)
        {
            _repositoryUsers = repositoryUsers;
        }

        public bool Createusers(usuarios usuarios)
        {
            return _repositoryUsers.Createusers(usuarios);
        }

        public IEnumerable<usuarios> GETALL()
        {
            return _repositoryUsers.GETALL();
        }

        public bool UpdateUsers(usuarios usuarios)
        {
            return _repositoryUsers.UpdateUsers(usuarios);
        }
    }
}
