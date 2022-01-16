using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Meniu
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int Fel_mancareId { get; set; }
        public Fel_mancare Fel_mancare { get; set; }
    }
}
