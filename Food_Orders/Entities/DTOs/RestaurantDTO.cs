using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities.DTOs
{
    public class RestaurantDTO
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Tip_pret { get; set; }
        public string Specific { get; set; }
        public Detalii_contactDTO Detalii_Contact { get; set; }
        public ICollection<Meniu> Meniuri { get; set; }

        public RestaurantDTO(Restaurant restaurant)
        {
            this.Id = restaurant.Id;
            this.Denumire = restaurant.Denumire;
            this.Tip_pret = restaurant.Tip_pret;
            this.Specific = restaurant.Specific;
            this.Detalii_Contact = this.Detalii_Contact;
            this.Meniuri = new List<Meniu>();
        }
    }
}
