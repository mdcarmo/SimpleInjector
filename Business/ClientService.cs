using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;
        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Client> Get()
        {
            return _repository.Get();
        }
    }
}
