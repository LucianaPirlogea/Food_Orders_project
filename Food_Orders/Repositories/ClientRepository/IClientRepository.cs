using Food_Orders.Models.Entities;
using Food_Orders.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.ClientRepository
{
    public interface IClientRepository : IGenericRepository<Client>
    {
    }
}
