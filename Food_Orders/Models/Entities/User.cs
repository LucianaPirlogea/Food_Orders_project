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
        
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
