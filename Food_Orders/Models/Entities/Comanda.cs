using Food_Orders.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Comanda
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int Fel_mancareId { get; set; }
        public Fel_mancare Fel_mancare { get; set; }
    }
}
