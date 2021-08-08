using CambiaContrasena.Models.BD;

namespace CambiaContrasena.Service
{
    public interface IServiceCambiaContrasena
    {
        bool CambiaContrasenaUsuario(usuarios usuarios);

        bool CambiaContrasenaCliente(customers customers);
    }
}
