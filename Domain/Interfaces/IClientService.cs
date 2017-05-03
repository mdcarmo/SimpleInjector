using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IClientService
    {
        IEnumerable<Client> Get();
    }
}
