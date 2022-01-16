using Food_Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Models.DTOs
{
    public class RegisterUserDTO
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Nr_telefon { get; set; }
        public string Password { get; set; }
        public ICollection<Adresa> Adrese { get; set; }
    }
}
