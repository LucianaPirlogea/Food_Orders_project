using Food_Orders.Entities;
using Food_Orders.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Models.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Nr_telefon { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Adresa> Adrese { get; set; }
        public ICollection<Comanda> Comenzi { get; set; }

        public ClientDTO(Client client)
        {
               this.Id = client.Id;
               this.Nume = client.Nume;
               this.Prenume = client.Prenume;
               this.Nr_telefon = client.Nr_telefon;
               this.Email = client.Email;
               this.Password = client.Password;
               this.Adrese = new List<Adresa>();
               this.Comenzi = new List<Comanda>();
        }
    }
}
