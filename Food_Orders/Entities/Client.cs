using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Nr_telefon { get; set; }
        public ICollection<Adresa> Adrese { get; set; }
        public ICollection<Comanda> Comenzi { get; set; }
    }
}
