using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Food_Orders.Models.Entities;
using Food_Orders.Entities;

namespace Food_Orders.Data
{
    public class FoodOrdersContext: IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public FoodOrdersContext(DbContextOptions<FoodOrdersContext> options) : base(options) { }

        //override public DbSet<User> Users { get; set; }
        public DbSet<SessionToken> SessionTokens { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<Fel_mancare> Feluri_mancare { get; set; }
        public DbSet<Restaurant> Restaurante { get; set; }
        public DbSet<Detalii_contact> Detalii_contacte { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Meniu> Meniuri { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many

            modelBuilder.Entity<User>()
                .HasMany(a => a.Adrese)
                .WithOne(b => b.User);

            // One to One

            modelBuilder.Entity<Restaurant>()
                .HasOne(a => a.Detalii_Contact)
                .WithOne(adr => adr.Restaurant);

            // Many to Many
            modelBuilder.Entity<Comanda>().HasKey(arp => new { arp.UserId, arp.Fel_mancareId });

            modelBuilder.Entity<Comanda>()
                .HasOne(arp => arp.User)
                .WithMany(a => a.Comenzi)
                .HasForeignKey(arp => arp.UserId);

            modelBuilder.Entity<Comanda>()
                .HasOne(arp => arp.Fel_mancare)
                .WithMany(rp => rp.Comenzi)
                .HasForeignKey(arp => arp.Fel_mancareId);

            modelBuilder.Entity<Meniu>().HasKey(arp => new { arp.RestaurantId, arp.Fel_mancareId });

            modelBuilder.Entity<Meniu>()
                .HasOne(arp => arp.Restaurant)
                .WithMany(a => a.Meniuri)
                .HasForeignKey(arp => arp.RestaurantId);

            modelBuilder.Entity<Meniu>()
                .HasOne(arp => arp.Fel_mancare)
                .WithMany(rp => rp.Meniuri)
                .HasForeignKey(arp => arp.Fel_mancareId);

            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });

                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId);
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);
            });

            base.OnModelCreating(modelBuilder);
        }

    }
    
}
