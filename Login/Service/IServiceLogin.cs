using Login.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Service
{
    public interface IServiceLogin
    {
        IEnumerable<usuarios> GETALL();

        IEnumerable<customers> GETALLC();


        bool Validate(string username, string password);

        bool ValidateCli(string username, string password);
    }
}
