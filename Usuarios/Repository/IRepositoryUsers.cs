using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Models.BD;

namespace Usuarios.Repository
{
    public interface IRepositoryUsers
    {
        IEnumerable<usuarios> GETALL();

        bool Createusers(usuarios usuarios);

        bool UpdateUsers(usuarios usuarios);

        //bool DeleteUsers(USERS USERS);
    }
}
