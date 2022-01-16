using Food_Orders.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Models.Entities
{
    public class User : IdentityUser<int>
    {
        public User() : base() { }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Nr_telefon { get; set; }
        public ICollection<Adresa> Adrese { get; set; }
        public ICollection<Comanda> Comenzi { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
