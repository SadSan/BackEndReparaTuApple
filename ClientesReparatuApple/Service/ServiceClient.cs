using ClientesReparatuApple.Models.BD;
using ClientesReparatuApple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesReparatuApple.Service
{
    public class ServiceClient : IServiceClient
    {
        private readonly IRepositoryClient _repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient)
        {
            _repositoryClient = repositoryClient;
        }

        public bool CreateClient(customers customers)
        {
            return _repositoryClient.CreateClient(customers);
        }

        public IEnumerable<customers> GETALL()
        {
            return _repositoryClient.GETALL();
        }

        public bool UpdateClient(customers customers)
        {
            return _repositoryClient.UpdateClient(customers);
        }
    }
}
