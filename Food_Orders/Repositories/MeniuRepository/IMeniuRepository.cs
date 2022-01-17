using Food_Orders.Entities;
using Food_Orders.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.MeniuRepository
{
    public interface IMeniuRepository : IGenericRepository<Meniu>
    {
        Task<List<Meniu>> GetAllMenusByRestaurantId(int id);
    }
}
