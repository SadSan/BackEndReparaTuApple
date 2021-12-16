﻿using Segumiento_Servicio.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Segumiento_Servicio.Repository
{
    public interface IRepositorySeguimiento
    {
        IEnumerable<seguimiento> GETALL();

        bool CreateSeguimiento(seguimiento seguimiento);

        bool UpdateSeguimiento(seguimiento seguimiento);
    }
}
