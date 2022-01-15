using Food_Orders.Data;
using Food_Orders.Entities;
using Food_Orders.Repositories.GenericRepository;
using Food_Orders.Repositories.Detalii_contactRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.RestaurantRepository
{
    public class RestaurantRepository: GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(FoodOrdersContext context) : base(context) { }

        public async Task<List<Restaurant>> GetAllRestaurantsWithContact()
        {
            
            return await _context.Restaurante.Include(a => a.Detalii_Contact).ToListAsync();
        }

        public async Task<Restaurant> GetByName(string name)
        {
            return await _context.Restaurante.Include(a => a.Detalii_Contact).Where(a => a.Denumire.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
