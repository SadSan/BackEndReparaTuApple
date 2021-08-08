using Segumiento_Servicio.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segumiento_Servicio.Repository
{
    public interface IRepositorySeguimiento
    {
        IEnumerable<Seguimiento> GETALL();

        bool CreateSeguimiento(Seguimiento seguimiento);

        bool UpdateSeguimiento(Seguimiento seguimiento);
    }
}
