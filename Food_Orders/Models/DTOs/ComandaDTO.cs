using Food_Orders.Entities;
using Food_Orders.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Models.DTOs
{
    public class ComandaDTO
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int Fel_mancareId { get; set; }
        public Fel_mancare Fel_mancare { get; set; }
    }
}
