using CambiaContrasena.Models.BD;
using CambiaContrasena.Repository;

namespace CambiaContrasena.Service
{
    public class ServiceCambiaContrasena : IServiceCambiaContrasena
    {
        private readonly IRepositoryCambiaContrasena _repositoryCambia;

        public ServiceCambiaContrasena(IRepositoryCambiaContrasena repositoryCambia)
        {
            _repositoryCambia = repositoryCambia;
        }

        public bool CambiaContrasenaCliente(customers customers)
        {
            return _repositoryCambia.CambiaContrasenaCliente(customers);
        }

        public bool CambiaContrasenaUsuario(usuarios usuarios)
        {
            return _repositoryCambia.CambiaContrasenaUsuario(usuarios);
        }
    }
}
