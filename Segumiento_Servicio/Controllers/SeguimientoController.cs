using Microsoft.AspNetCore.Mvc;
using Segumiento_Servicio.Dtos;
using Segumiento_Servicio.Models.BD;
using Segumiento_Servicio.Service;
using System.Linq;

namespace Segumiento_Servicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguimientoController : ControllerBase
    {
        private readonly IContextDatabase _contextDatabase;
        private readonly IServiceSeguimiento _seguimiento;

        public SeguimientoController(IContextDatabase contextDatabase, IServiceSeguimiento seguimiento)
        {
            _contextDatabase = contextDatabase;
            _seguimiento = seguimiento;
        }



        [HttpGet]
        
        public IActionResult Get()
        {

            return Ok(_seguimiento.GETALL());
        }

        [HttpPost]

        public IActionResult CreateSeguimiento([FromBody] InsertSeguimiento insert)
        {
            try
            {
                var Seguimieneto = _contextDatabase.seguimiento.Any(x => x.nombre_seguimiento == insert.nombre_seguimiento);
                if (Seguimieneto == false)
                {
                    Models.BD.Seguimiento InserSeguimiento = new Models.BD.Seguimiento()
                    {
                        nombre_seguimiento = insert.nombre_seguimiento,
                        descripcion = insert.descripcion

                    };
                    _seguimiento.CreateSeguimiento(InserSeguimiento);
                }
                return Ok(1);
                    
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPut]

        public IActionResult updateSeguimiento([FromBody] UpdateSeguimiento update)
        {
            try
            {
                var Seguimieneto = _contextDatabase.seguimiento.Any(x => x.id_seguimiento == update.id_seguimiento);
                if (Seguimieneto)
                {
                    Models.BD.Seguimiento InserSeguimiento = new Models.BD.Seguimiento()
                    {
                        id_seguimiento = update.id_seguimiento,
                        nombre_seguimiento = update.nombre_seguimiento,
                        descripcion = update.descripcion

                    };
                    _seguimiento.CreateSeguimiento(InserSeguimiento);
                }
                return Ok(1);

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }

}
