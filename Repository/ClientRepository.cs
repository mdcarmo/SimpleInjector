using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class ClientRepository : IClientRepository
    {
        public IEnumerable<Client> Get()
        {
            for (var i = 0; i < 20; i++)
                yield return new Client(i, "First Name", "Last Name", i, DateTime.Now);
        }
    }
}
