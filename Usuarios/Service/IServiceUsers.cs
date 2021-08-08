using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Models.BD;

namespace Usuarios.Service
{
   public  interface IServiceUsers
    {
        IEnumerable<usuarios> GETALL();

        bool Createusers(usuarios usuarios);

        bool UpdateUsers(usuarios usuarios);
    }
}
