using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Segumiento_Servicio.Dtos;
using Segumiento_Servicio.Models.BD;
using Segumiento_Servicio.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Segumiento_Servicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguimientoController : ControllerBase
    {
        private readonly IContextDatabase _contextDatabase;
        private readonly IServiceSeguimiento _seguimiento;
        private readonly IDistributedCache _distributedCache;


        public SeguimientoController(IContextDatabase contextDatabase, IServiceSeguimiento seguimiento, IDistributedCache distributedCache)
        {
            _contextDatabase = contextDatabase;
            _seguimiento = seguimiento;
            _distributedCache = distributedCache;
        }



        [HttpGet]


        public IActionResult Get(int cod_seguimiento)
        {

            string keyData = $"historydata-{cod_seguimiento}";
            var cache = _distributedCache.GetString(keyData);
            IEnumerable<seguimiento> model;

            var Seguimieneto = _contextDatabase.seguimiento.Any(x => x.cod_seguimiento == cod_seguimiento);

            if (Seguimieneto)
            {
                if (cache == null)
                {
                    var retorno = _seguimiento.GETALL();

                    // model = _contextDatabase.seguimiento.Select(s => s).ToList();

                    model = _contextDatabase.seguimiento.Where(s => s.cod_seguimiento == cod_seguimiento).ToList();

                           //descripcion = _contextDatabase.seguimiento
                           //.Where(a => a.cod_seguimiento == update.cod_seguimiento)
                           //.Select(a => a.descripcion)
                           //.FirstOrDefault();




                    var options = new DistributedCacheEntryOptions()
                                            .SetSlidingExpiration(TimeSpan.FromSeconds(10));

                    _distributedCache.SetString(keyData, JsonConvert.SerializeObject(model), options);
                }

                else
                {


                    model = JsonConvert.DeserializeObject<List<seguimiento>>(cache);

                }


                return Ok(model);

            }

            else
            {
                return BadRequest(5);
            }
        }

        [HttpPost]

        public IActionResult CreateSeguimiento([FromBody] InsertSeguimiento insert)
        {
            try
            {
                var codigosegumiento = _contextDatabase.seguimiento .Any(x => x.cod_seguimiento == insert.cod_seguimiento);
                if (codigosegumiento == false)
                {
                    Models.BD.seguimiento InserSeguimiento = new Models.BD.seguimiento()
                    {
                        nombre_seguimiento = insert.nombre_seguimiento,
                        descripcion = insert.descripcion,
                        id_equipo = insert.id_equipo,
                        cod_seguimiento = insert.cod_seguimiento,
                        Idusuario = insert.Idusuario,
                        nombre_cliente = insert.nombre_cliente,
                        celular_cliente = insert.celular_cliente,
                        direccion_cliente = insert.direccion_cliente,
                        confirmacion_cliente = insert.confirmacion_cliente,
                        reporte_falla = insert.reporte_falla,
                        referencia_equipo = insert.referencia_equipo,
                        modelo = insert.modelo,
                        disco = insert.disco,
                        valor_negociado = insert.valor_negociado,
                        Ob_cliente = insert.Ob_cliente,
                        correo_cliente = insert.correo_cliente
                         
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

        public IActionResult UpdateSeguimiento([FromBody] UpdateSeguimiento update)
        {
            try
            {
                var Seguimieneto = _contextDatabase.seguimiento.Any(x => x.cod_seguimiento == update.cod_seguimiento);
                var itsok = false;

               // var idsegumiento = _contextDatabase.seguimiento.Where(x => x.cod_seguimiento == update.cod_seguimiento).FirstOrDefault().id_seguimiento;
                if (Seguimieneto)
                {


                    var idcodsemimiento = _contextDatabase.seguimiento
                           .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                           .Select(a => a.id_seguimiento)
                           .FirstOrDefault();


                    var descripcion = _contextDatabase.seguimiento
                           .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                           .Select(a => a.descripcion)
                           .FirstOrDefault();


                    var Id_equipo = _contextDatabase.seguimiento
                          .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                          .Select(a => a.id_equipo)
                          .FirstOrDefault();


                    var Cod_segumiento = _contextDatabase.seguimiento
                          .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                          .Select(a => a.cod_seguimiento)
                          .FirstOrDefault();

                    var nombre_cliente = _contextDatabase.seguimiento
                          .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                          .Select(a => a.nombre_cliente)
                          .FirstOrDefault();

                    var telfono_cliente = _contextDatabase.seguimiento
                         .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                         .Select(a => a.celular_cliente)
                         .FirstOrDefault();


                    var direccion = _contextDatabase.seguimiento
                         .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                         .Select(a => a.direccion_cliente)
                         .FirstOrDefault();


                    var reportefalla = _contextDatabase.seguimiento
                         .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                         .Select(a => a.reporte_falla)
                         .FirstOrDefault();


                    var refernciaequipo = _contextDatabase.seguimiento
                        .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                        .Select(a => a.referencia_equipo)
                        .FirstOrDefault();



                    var modelo = _contextDatabase.seguimiento
                        .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                        .Select(a => a.modelo)
                        .FirstOrDefault();


                    var ob_cliente = _contextDatabase.seguimiento
                       .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                       .Select(a => a.Ob_cliente)
                       .FirstOrDefault();


                    var disco = _contextDatabase.seguimiento
                       .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                       .Select(a => a.disco)
                       .FirstOrDefault();


                    var correo = _contextDatabase.seguimiento
                       .Where(a => a.cod_seguimiento == update.cod_seguimiento)
                       .Select(a => a.correo_cliente)
                       .FirstOrDefault();


                    Models.BD.seguimiento InserSeguimiento = new Models.BD.seguimiento()
                    {
                        id_seguimiento = idcodsemimiento,
                        nombre_seguimiento = update.nombre_seguimiento,
                        descripcion = descripcion,
                        id_equipo = Id_equipo,
                        cod_seguimiento = Cod_segumiento,
                        Idusuario = update.Idusuario,
                        nombre_cliente = nombre_cliente,
                        celular_cliente = telfono_cliente,
                        direccion_cliente = direccion,
                        confirmacion_cliente = update.confirmacion_cliente,
                        reporte_falla = reportefalla,
                        referencia_equipo = refernciaequipo,
                        modelo = modelo,
                        disco = disco,
                        valor_negociado = update.valor_negociado,
                        Ob_cliente = ob_cliente,
                        correo_cliente = correo
                    };
                    _seguimiento.UpdateSeguimiento(InserSeguimiento);
                    itsok = true;

                }
                if (itsok == true)
                {
                    return Ok(1);
                }
                return Ok(2);

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("Admin")]

        public IActionResult GetALL()
        {

            return Ok(_seguimiento.GETALL());
        }
       



    }

}
