using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Detalii_contact
    {
        public int Id { get; set; }
        public string Tel_mobil { get; set; }
        public string Tel_fix { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
