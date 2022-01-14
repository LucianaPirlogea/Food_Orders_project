using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Tip_pret { get; set; }
        public string Specific { get; set; }
        public Detalii_contact Detalii_Contact { get; set; }
        public ICollection<Meniu> Meniuri { get; set; }
    }
}
