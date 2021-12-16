using ClientesReparatuApple.Dtos;
using ClientesReparatuApple.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Models.BD;

namespace ClientesReparatuApple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IServiceClient _serviceClient;
        private readonly IContextDatabase _contextDatabase;

        public ClientController(IServiceClient serviceClient, IContextDatabase contextDatabase)
        {
            _serviceClient = serviceClient;
            _contextDatabase = contextDatabase;
        }


        [HttpGet]

        [AllowAnonymous]
        public IActionResult Get()
        {

            return Ok(_serviceClient.GETALL());
        }


        [HttpPost]

        public IActionResult CreatreUser([FromBody] InsertClient insert)
        {
            try
            {
                if (insert.documento_cliente != null)
                {

                    var encryp = new Encryption();
                    string nueva = "";
                    nueva = encryp.encriptar(insert.passwords);

                    Models.BD.customers NewUser = new Models.BD.customers()
                    {
                        nombre_cliente = insert.nombre_cliente,
                        documento_cliente = insert.documento_cliente,
                        passwords = nueva,
                        tipo_documento = insert.tipo_documento,
                        correo_cliente = insert.correo_cliente,
                        Acepto_Registro = insert.Acepto_Registro,
                        terminos_condiciones = insert.terminos_condiciones,
                        telefono_cliente = insert.telefono_cliente,
                        telefono2_cliente = insert.telefono2_cliente,
                        fecha_creacion_cli = DateTime.Now,
                       fecha_nacimiento_cli = insert.fecha_nacimiento
                    };

                    _serviceClient.CreateClient(NewUser);

                    return Ok(1);
                }

                else
                {
                    return BadRequest(0);
                }

            }
            catch (Exception)
            {

                throw;
            }


        }


      [HttpPut]
        public IActionResult UpdatereUser([FromBody] UpdateClient update)
        {
            try
            {
                var Codigo = _contextDatabase.customers.Any(x => x.Id_cliente == update.Id_cliente);

               

                if (Codigo)
                {

                    var encryp = new Encryption();
                    string nueva = "";
                    nueva = encryp.encriptar(update.passwords);



                    var CREATED_ADS = _contextDatabase.customers
                            .Where(a => a.Id_cliente == update.Id_cliente)
                            .Select(a => a.fecha_nacimiento_cli)
                            .FirstOrDefault();

                    Models.BD.customers NewUser = new Models.BD.customers()
                    {
                       Id_cliente = update.Id_cliente,
                        nombre_cliente = update.nombre_cliente,
                        documento_cliente = update.documento_cliente,
                        passwords = nueva,
                        tipo_documento = update.tipo_documento,
                        correo_cliente = update.correo_cliente,
                        fecha_nacimiento_cli = update.fecha_nacimiento_cli,
                        Acepto_Registro = update.Acepto_Registro,
                        terminos_condiciones = update.terminos_condiciones,
                        telefono_cliente = update.telefono_cliente,
                        telefono2_cliente = update.telefono2_cliente,
                        fecha_creacion_cli = CREATED_ADS,
                        fecha_actualizacion_cli = DateTime.Now
                    };

                    _serviceClient.CreateClient(NewUser);

                    return Ok(1);
                }

                else
                {
                    return BadRequest(0);
                }

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
