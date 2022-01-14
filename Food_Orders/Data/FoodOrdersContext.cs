using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Food_Orders.Entities;

namespace Food_Orders.Data
{
    public class FoodOrdersContext: DbContext
    {
        public FoodOrdersContext(DbContextOptions<FoodOrdersContext> options) : base(options) { }

        public DbSet<Client> Clienti { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<Fel_mancare> Feluri_mancare { get; set; }
        public DbSet<Restaurant> Restaurante { get; set; }
        public DbSet<Detalii_contact> Detalii_contacte { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Meniu> Meniuri { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many

            modelBuilder.Entity<Client>()
                .HasMany(a => a.Adrese)
                .WithOne(b => b.Client);

            // One to One

            modelBuilder.Entity<Restaurant>()
                .HasOne(a => a.Detalii_Contact)
                .WithOne(adr => adr.Restaurant);

            // Many to Many
            modelBuilder.Entity<Comanda>().HasKey(arp => new { arp.ClientId, arp.Fel_mancareId });

            modelBuilder.Entity<Comanda>()
                .HasOne(arp => arp.Client)
                .WithMany(a => a.Comenzi)
                .HasForeignKey(arp => arp.ClientId);

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

            base.OnModelCreating(modelBuilder);
        }

    }
    
}
