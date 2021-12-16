using Login.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Repository
{
    public interface IRepositoryLogin
    {
        IEnumerable<usuarios> GETALL();

        IEnumerable<customers> GETALLC();

    }
}
