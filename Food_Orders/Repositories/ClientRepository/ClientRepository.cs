using Food_Orders.Data;
using Food_Orders.Models.Entities;
using Food_Orders.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.ClientRepository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(FoodOrdersContext context) : base(context) { }
    }
}
