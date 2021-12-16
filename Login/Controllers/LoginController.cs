using Cross.Jwt.Src;
using Login.Dtos;
using Login.Models.BD;
using Login.Repository;
using Login.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IServiceLogin _serviceLogin;
        private readonly IRepositoryLogin _repositoryLogin;
        private readonly JwtOptions _Options;

        public LoginController(IServiceLogin serviceLogin, IRepositoryLogin repositoryLogin, IOptionsSnapshot<JwtOptions> Options)
        {
            _serviceLogin = serviceLogin;
            _repositoryLogin = repositoryLogin;
            _Options = Options.Value;
        }


        [HttpGet]

        [Route("/LitarLoginUsuarios")]
        public IActionResult Get()
        {

            return Ok(_serviceLogin.GETALL());

        }



        [HttpGet]

        [Route("/LitarLoginClientes")]
        public IActionResult Gets()
        {

            return Ok(_serviceLogin.GETALLC());

        }


        [HttpPost]

        [Route("/LoginInUsuarios")]
        public IActionResult Post ([FromBody] LoginUsuarios loginUsuarios)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(loginUsuarios.correo)|| !String.IsNullOrWhiteSpace(loginUsuarios.clave))
                {

                    var User = loginUsuarios.correo ;
                    var PWD = loginUsuarios.clave;

                    var encryp = new Encryption();
                    var Pass = encryp.encriptar(PWD);

                    if (!_serviceLogin.Validate(User, Pass))
                    {

                        

                        return Unauthorized();
                    }

                   


                    Response.Headers.Add("access-control-expose-headers", "Authorization");
                    Response.Headers.Add("Authorization", JwtToken.Create(_Options));

                    IEnumerable<usuarios> model;
                    var retorno = _serviceLogin.GETALL();
                    model = retorno.Where(x => x.correo == loginUsuarios.correo).ToList();
                    return Ok(model.Select(x => new { x.id_rol, x.Idusuario }));

                   // return Ok();
                }

                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }



        }


        [HttpPost]

        [Route("/LoginInClientes")]
        public IActionResult Posts([FromBody] LoginCliente loginCliente)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(loginCliente.correo_cliente) || !String.IsNullOrWhiteSpace(loginCliente.passwords))
                {

                    var User = loginCliente.correo_cliente;
                    var PWD = loginCliente.passwords;

                    var encryp = new Encryption();
                    var Pass = encryp.encriptar(PWD);

                    if (!_serviceLogin.Validate(User, Pass))
                    {
                        return Unauthorized();
                    }


                    Response.Headers.Add("access-control-expose-headers", "Authorization");
                    Response.Headers.Add("Authorization", JwtToken.Create(_Options));


                    return Ok();
                }

                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }



        }

    }
}
