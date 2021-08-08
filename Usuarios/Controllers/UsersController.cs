using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Dtos;
using Usuarios.Models.BD;
using Usuarios.Service;

namespace Usuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceUsers _serviceUsers;
        private readonly IContextDatabase _contextDatabase;
        private readonly CreatePassword _createpasword;

        public UsersController(IServiceUsers serviceUsers, IContextDatabase contextDatabase,
            IOptionsSnapshot<CreatePassword> createpasword)
        {
            _serviceUsers = serviceUsers;
            _contextDatabase = contextDatabase;
            _createpasword = createpasword.Value;
        }


        [HttpGet]

        [AllowAnonymous]
        public IActionResult Get()
        {

            return Ok(_serviceUsers.GETALL());
        }

        [HttpPost]
        [AllowAnonymous]

        public IActionResult CreatreUser([FromBody] Insertusers insert)
        {
            try
            {
                if (insert.cedula != null)
                {

                    var encryp = new Encryption();
                    string nueva = "";
                    nueva = encryp.encriptar(insert.clave);

                    Models.BD.usuarios NewUser = new Models.BD.usuarios()
                    {
                        nombre = insert.nombre,
                        apellido = insert.apellido,
                        clave = nueva,
                        telefono = insert.telefono,
                        id_estado = insert.id_estado,
                        id_rol = insert.id_rol,
                        cedula = insert.cedula,
                        codigo = insert.codigo,
                        correo = insert.correo,
                        tipocontrato = insert.tipocontrato,
                        fechanacimiento = insert.fechanacimiento,
                        fecharegistro = DateTime.Now
                    }; 
                    
                    _serviceUsers.Createusers(NewUser);

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

        public IActionResult UpdateUser([FromBody] UpdateUser updateUser)
        {

            try
            {
                var Codigo = _contextDatabase.usuarios.Any(x => x.cedula == updateUser.cedula);

                if (Codigo)
                {

                    var encryp = new Encryption();
                    string nueva = "";
                    nueva = encryp.encriptar(updateUser.clave);

                    Models.BD.usuarios NewUser = new Models.BD.usuarios()
                    {
                        Idusuario = updateUser.Idusuario,
                        nombre = updateUser.nombre,
                        apellido = updateUser.apellido,
                        clave = nueva,
                        telefono = updateUser.telefono,
                        id_estado = updateUser.id_estado,
                        id_rol = updateUser.id_rol,
                        cedula = updateUser.cedula,
                        codigo = updateUser.codigo,
                        correo = updateUser.correo,
                        tipocontrato = updateUser.tipocontrato,
                        fechanacimiento = updateUser.fechanacimiento,
                        fecharegistro = DateTime.Now
                    };

                   
                      _serviceUsers.Createusers(NewUser);

                    return Ok(1);

                }

                else
                {
                    return Ok(0);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }




    }
}
