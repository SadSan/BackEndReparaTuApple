
using PantallaFuncionarios.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PantallaFuncionarios.Repository
{
    public interface IRepositorySeguimiento
    {
        IEnumerable<Seguimiento> PantallaAdmin();

        IEnumerable<Seguimiento> Tecnico();

        IEnumerable<Seguimiento> Domiciliario();

         IEnumerable<Seguimiento> Comercial();
    }
}
