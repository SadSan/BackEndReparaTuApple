using Login.Models.BD;
using Login.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Service
{

    public class ServiceLogin : IServiceLogin
    {
        private readonly IRepositoryLogin _login;

        public ServiceLogin(IRepositoryLogin login)
        {
            _login = login;
        }

        public IEnumerable<usuarios> GETALL()
        {
            return _login.GETALL();
        }

        public IEnumerable<customers> GETALLC()
        {
            return _login.GETALLC();
        }

        public bool Validate(string username, string password)
        {
            var list = _login.GETALL();

            var access = list.Where(x => x.correo == username && x.clave == password).FirstOrDefault();

            if (access != null)
            {
                return true;


            }

            else
            {
                return false;
            }
        }

        public bool ValidateCli(string username, string password)
        {
            var list = _login.GETALLC();

            var access = list.Where(x => x.correo_cliente == username && x.passwords == password).FirstOrDefault();

            if (access != null)
            {
                return true;


            }

            else
            {
                return false;
            }
        }
    }
}
