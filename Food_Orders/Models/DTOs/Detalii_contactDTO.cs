using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities.DTOs
{
    public class Detalii_contactDTO
    {
        public int Id { get; set; }
        public string Tel_mobil { get; set; }
        public string Tel_fix { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int RestaurantId { get; set; }
     

        public Detalii_contactDTO(Detalii_contact contact)
        {
            this.Id = contact.Id;
            this.Tel_mobil = contact.Tel_mobil;
            this.Tel_fix = contact.Tel_fix;
            this.Email = contact.Email;
            this.RestaurantId = contact.RestaurantId;
            
        }
    }
}
