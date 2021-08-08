using ClientesReparatuApple.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesReparatuApple.Service
{
    public interface IServiceClient
    {
        IEnumerable<customers> GETALL();

        bool CreateClient(customers customers);

        bool UpdateClient(customers customers);
    }
}
