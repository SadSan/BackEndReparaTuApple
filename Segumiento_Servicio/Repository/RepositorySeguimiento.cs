using Segumiento_Servicio.Models.BD;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Segumiento_Servicio.Repository
{
    public class RepositorySeguimiento : IRepositorySeguimiento
    {
        private readonly IContextDatabase _contextDatabase;

        public RepositorySeguimiento(IContextDatabase contextDatabase)
        {
            _contextDatabase = contextDatabase;
        }

        public bool CreateSeguimiento(seguimiento seguimiento)
        {
            _contextDatabase.seguimiento.Add(seguimiento);
            _contextDatabase.SaveChanges();
            return true;
        }

        public IEnumerable<seguimiento> GETALL()
        {
            return _contextDatabase.seguimiento.AsNoTracking().ToList();
        }

        public bool UpdateSeguimiento(seguimiento seguimiento)
        {
            _contextDatabase.seguimiento.Update(seguimiento);
            _contextDatabase.SaveChanges();
            return true;
        }
    }
}
