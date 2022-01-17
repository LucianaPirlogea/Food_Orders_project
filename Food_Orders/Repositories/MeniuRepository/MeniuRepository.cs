using Food_Orders.Data;
using Food_Orders.Entities;
using Food_Orders.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.MeniuRepository
{
    public class MeniuRepository: GenericRepository<Meniu>, IMeniuRepository
    {
        public MeniuRepository(FoodOrdersContext context) : base(context) { }

        public async Task<List<Meniu>> GetAllMenusByRestaurantId(int id)
        {
            return await _context.Meniuri.Where(a => a.RestaurantId.Equals(id)).ToListAsync();
        }
    }
}
