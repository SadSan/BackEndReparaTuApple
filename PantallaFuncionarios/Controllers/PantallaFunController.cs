using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PantallaFuncionarios.Models.BD;
using PantallaFuncionarios.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PantallaFuncionarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantallaFunController : ControllerBase
    {
        private readonly IContextDatabase _contextDatabase;
        private readonly IServiceSeguimiento _seguimiento;

        public PantallaFunController(IContextDatabase contextDatabase, IServiceSeguimiento seguimiento)
        {
            _contextDatabase = contextDatabase;
            _seguimiento = seguimiento;
     
        }


        [HttpGet]


        [Route("ListaAdmin")]

        public IActionResult PantallaAdmin()
        {

            var TipoUsuario = 0; // Recibir tipo de usuario

            if (TipoUsuario == 1 )
            {
                var adminp = from Seguimiento in 

                return Ok(_seguimiento.PantallaAdmin(idcodsemimiento));
            }
            
        }


    }



}
