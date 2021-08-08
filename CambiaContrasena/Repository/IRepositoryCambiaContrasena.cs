using CambiaContrasena.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CambiaContrasena.Repository
{
    public interface IRepositoryCambiaContrasena
    {
        bool CambiaContrasenaUsuario(usuarios usuarios);

        bool CambiaContrasenaCliente(customers customers);

    }
}
