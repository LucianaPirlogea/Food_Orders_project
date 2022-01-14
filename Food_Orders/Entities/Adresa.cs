using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Adresa
    {
        public int Id { get; set; }
        public string Strada { get; set; }
        public int Numar { get; set; }
        public string Oras { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }

    }
}
