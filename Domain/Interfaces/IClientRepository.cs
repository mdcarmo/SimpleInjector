﻿using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> Get();
    }
}
