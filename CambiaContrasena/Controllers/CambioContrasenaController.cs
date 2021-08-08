using CambiaContrasena.Dtos;
using CambiaContrasena.Models.BD;
using CambiaContrasena.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CambiaContrasena.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CambioContrasenaController : ControllerBase
    {
        private readonly IServiceCambiaContrasena _serviceCambiaContrasena;
        private readonly IContextDatabase _contextDatabase;
        private readonly CreatePassword _createpasword;
        public CambioContrasenaController(IServiceCambiaContrasena serviceCambiaContrasena, IContextDatabase contextDatabase,
            IOptionsSnapshot<CreatePassword> createpasword)
        {
           _serviceCambiaContrasena = serviceCambiaContrasena;
            _contextDatabase = contextDatabase;
            _createpasword = createpasword.Value;
        }

        [HttpPut("USUARIO")]

         public IActionResult UpdateContrasenaUsuario([FromBody] ActualizaClave actualizaClave)
        {
            try
            {
               

                var Codigo = _contextDatabase.usuarios.Any(x => x.Idusuario == actualizaClave.Idusuario);


                if (Codigo)

                {
                    var encryp = new Encryption();
                    string nueva = "";
                    nueva = encryp.encriptar(actualizaClave.clave);

                    var nombre = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.nombre)
                           .FirstOrDefault();


                    var apellido = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.apellido)
                           .FirstOrDefault();

                    var telefono = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.telefono)
                           .FirstOrDefault();

                    var Id_estado = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.id_estado)
                           .FirstOrDefault();

                    var Id_rol = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.id_rol)
                           .FirstOrDefault();

                    var cedula = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.cedula)
                           .FirstOrDefault();

                    var codigo = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.codigo)
                           .FirstOrDefault();

                    var correo = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.correo)
                           .FirstOrDefault();

                    var tipocontrato = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.tipocontrato)
                           .FirstOrDefault();

                    var fechanacimiento = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.fechanacimiento)
                           .FirstOrDefault();

                    var fecharegistro = _contextDatabase.usuarios
                           .Where(a => a.Idusuario == actualizaClave.Idusuario)
                           .Select(a => a.fecharegistro)
                           .FirstOrDefault();


                    Models.BD.usuarios ClaveNueva = new Models.BD.usuarios()
                    {
                        Idusuario = actualizaClave.Idusuario,
                        nombre = nombre,
                        apellido = apellido,
                        clave = nueva,
                        telefono = telefono,
                        id_estado = Id_estado,
                        id_rol = Id_rol,
                        cedula = cedula,
                        codigo = codigo,
                        correo = correo,
                        tipocontrato = tipocontrato,
                        fechanacimiento = fechanacimiento,
                        fecharegistro = fechanacimiento
                    };

                    _serviceCambiaContrasena.CambiaContrasenaUsuario(ClaveNueva);

                    
                }

                return Ok(1);
            }
            catch (Exception)
            {

                throw;
            }

            
        }


        [HttpPut("CLIENTE")]

        public IActionResult UpdateContrasenaCliente([FromBody] ActualizaClaveCliente actualizaClavecli)
        {
            

            try
            {
                var Codigo = _contextDatabase.customers.Any(x => x.Id_cliente == actualizaClavecli.Id_cliente);

                if (Codigo)
                {
                    var encryp = new Encryption();
                    string nuevas = "";
                    nuevas = encryp.encriptar(actualizaClavecli.passwords);



                    var nombre = _contextDatabase.customers
                          .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                          .Select(a => a.nombre_cliente)
                          .FirstOrDefault();


                    var Documento = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.documento_cliente)
                           .FirstOrDefault();

                    var tipodocumento = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.tipo_documento)
                           .FirstOrDefault();

                    var correo = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.correo_cliente)
                           .FirstOrDefault();

                    var fechanacimiento = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.fecha_nacimiento_cli)
                           .FirstOrDefault();

                    var Aceptoregistro = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.Acepto_Registro)
                           .FirstOrDefault();

                    var terminoycondiciones = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.terminos_condiciones)
                           .FirstOrDefault();

                    var telefono = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.telefono_cliente)
                           .FirstOrDefault();

                    var telefono2 = _contextDatabase.customers
                           .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                           .Select(a => a.telefono2_cliente)
                           .FirstOrDefault();


                    var creacion = _contextDatabase.customers
                          .Where(a => a.Id_cliente == actualizaClavecli.Id_cliente)
                          .Select(a => a.fecha_creacion_cli)
                          .FirstOrDefault();

                    Models.BD.customers ClaveNuevacli = new Models.BD.customers()
                    {
                        Id_cliente = actualizaClavecli.Id_cliente,
                        nombre_cliente = nombre,
                        documento_cliente = Documento,
                        passwords = nuevas,
                        tipo_documento = tipodocumento,
                        correo_cliente = correo,
                        fecha_nacimiento_cli = fechanacimiento,
                        Acepto_Registro = Aceptoregistro,
                        terminos_condiciones = terminoycondiciones,
                        telefono_cliente = telefono,
                        telefono2_cliente = telefono2,
                        fecha_creacion_cli = creacion,
                        fecha_actualizacion_cli = DateTime.Now
                    };

                    _serviceCambiaContrasena.CambiaContrasenaCliente(ClaveNuevacli);
                }


                return Ok(1);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
