using ClientesReparatuApple.Models.BD;
using System.Collections.Generic;

namespace ClientesReparatuApple.Repository
{
    public interface IRepositoryClient
    {
        IEnumerable<customers> GETALL();

        bool CreateClient(customers customers);

        bool UpdateClient(customers customers);

        //bool DeleteUsers(USERS USERS);
    }
}
