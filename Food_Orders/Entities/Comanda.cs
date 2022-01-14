using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Comanda
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int Fel_mancareId { get; set; }
        public Fel_mancare Fel_mancare { get; set; }
    }
}
