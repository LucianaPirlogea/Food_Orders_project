using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Data
{
    public class FoodOrdersContext: DbContext
    {
        public FoodOrdersContext(DbContextOptions<FoodOrdersContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
    
}
