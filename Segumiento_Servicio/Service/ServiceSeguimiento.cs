using Segumiento_Servicio.Models.BD;
using Segumiento_Servicio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segumiento_Servicio.Service
{
    public class ServiceSeguimiento : IServiceSeguimiento
    {
        private readonly IRepositorySeguimiento _seguimiento;

        public ServiceSeguimiento(IRepositorySeguimiento seguimiento)
        {
            _seguimiento = seguimiento;
        }

        public bool CreateSeguimiento(seguimiento seguimiento)
        {
            return _seguimiento.CreateSeguimiento(seguimiento);
        }

        public IEnumerable<seguimiento> GETALL()
        {
            return _seguimiento.GETALL();
        }

        public bool UpdateSeguimiento(seguimiento seguimiento)
        {
            return _seguimiento.UpdateSeguimiento(seguimiento);
        }
    }
}
