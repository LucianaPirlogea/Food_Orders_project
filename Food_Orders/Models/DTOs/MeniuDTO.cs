using Food_Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Models.DTOs
{
    public class MeniuDTO
    {
        public int RestaurantId { get; set; }
        //public Restaurant Restaurant { get; set; }
        public int Fel_mancareId { get; set; }
        //public Fel_mancare Fel_mancare { get; set; }
        public MeniuDTO(Meniu meniu)
        {
            this.RestaurantId = meniu.RestaurantId;
            this.Fel_mancareId = meniu.Fel_mancareId;
        }
    }
}
