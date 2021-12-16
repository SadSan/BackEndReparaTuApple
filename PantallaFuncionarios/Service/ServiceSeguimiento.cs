using PantallaFuncionarios.Models.BD;
using PantallaFuncionarios.Repository;
using System.Collections.Generic;

namespace PantallaFuncionarios.Service
{
    public class ServiceSeguimiento : IServiceSeguimiento
    {
        private readonly IRepositorySeguimiento _seguimiento;

        public ServiceSeguimiento(IRepositorySeguimiento seguimiento)
        {
            _seguimiento = seguimiento;
        }

        public IEnumerable<Seguimiento> Comercial()
        {
            return _seguimiento.Comercial();
        }

        public IEnumerable<Seguimiento> Domiciliario()
        {
            return _seguimiento.Domiciliario();
        }

        public IEnumerable<Seguimiento> PantallaAdmin()
        {
            return _seguimiento.PantallaAdmin();
        }

        public IEnumerable<Seguimiento> Tecnico()
        {
            return _seguimiento.Tecnico();
        }
    }
}
