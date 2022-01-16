using Food_Orders.Data;
using Food_Orders.Entities;
using Food_Orders.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.Fel_mancareRepository
{
    public class Fel_mancareRepository : GenericRepository<Fel_mancare>, IFel_mancareRepository
    {
        public Fel_mancareRepository(FoodOrdersContext context) : base(context) { }

      
    }
}
