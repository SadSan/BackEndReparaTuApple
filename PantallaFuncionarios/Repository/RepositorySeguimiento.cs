
using PantallaFuncionarios.Models.BD;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PantallaFuncionarios.Repository
{
    public class RepositorySeguimiento : IRepositorySeguimiento
    {
        private readonly IContextDatabase _contextDatabase;

        public RepositorySeguimiento(IContextDatabase contextDatabase)
        {
            _contextDatabase = contextDatabase;
        }

        public IEnumerable<Seguimiento> Comercial()
        {
            return _contextDatabase.seguimiento.AsNoTracking().ToList();
        }

        public IEnumerable<Seguimiento> Domiciliario()
        {
            return _contextDatabase.seguimiento.AsNoTracking().ToList();
        }

        public IEnumerable<Seguimiento> GETALL()
        {
            return _contextDatabase.seguimiento.AsNoTracking().ToList();
        }

        public IEnumerable<Seguimiento> PantallaAdmin()
        {
            return _contextDatabase.seguimiento.AsNoTracking().ToList();
        }

        public IEnumerable<Seguimiento> Tecnico()
        {
            return _contextDatabase.seguimiento.AsNoTracking().ToList();
        }
    }
}
