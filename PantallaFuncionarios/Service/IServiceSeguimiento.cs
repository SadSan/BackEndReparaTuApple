using PantallaFuncionarios.Models.BD;
using System.Collections.Generic;

namespace PantallaFuncionarios.Service
{
    public interface IServiceSeguimiento
    {
        IEnumerable<Seguimiento> PantallaAdmin();

        IEnumerable<Seguimiento> Tecnico();

        IEnumerable<Seguimiento> Domiciliario();

        IEnumerable<Seguimiento> Comercial();
    }
}
