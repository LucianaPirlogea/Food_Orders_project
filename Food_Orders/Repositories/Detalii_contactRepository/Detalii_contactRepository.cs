using Food_Orders.Data;
using Food_Orders.Entities;
using Food_Orders.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.Detalii_contactRepository
{
    public class Detalii_contactRepository : GenericRepository<Detalii_contact>, IDetalii_contactRepository
    {
        public Detalii_contactRepository(FoodOrdersContext context) : base(context) { }

        public async Task<Detalii_contact> GetByRestaurantId(int id)
        {
            return await _context.Detalii_contacte.Where(a => a.RestaurantId.Equals(id)).FirstOrDefaultAsync();
        }
    }
}
