using Food_Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Models.DTOs
{
    public class Fel_mancareDTO
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Cantitate { get; set; }
        public int Pret { get; set; }
        public ICollection<Comanda> Comenzi { get; set; }
        public ICollection<Meniu> Meniuri { get; set; }

        public Fel_mancareDTO(Fel_mancare mancare)
        {
            this.Id = mancare.Id;
            this.Denumire = mancare.Denumire;
            this.Cantitate = mancare.Cantitate;
            this.Pret = mancare.Pret;
            //this.Comenzi = new List<Comanda>();
            //this.Meniuri = new List<Meniu>();
        }
    }
}
