using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Fel_mancare
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Cantitate { get; set; }
        public int Pret { get; set; }
        public ICollection<Comanda> Comenzi { get; set; }
        public ICollection<Meniu> Meniuri { get; set; }
    }
}
