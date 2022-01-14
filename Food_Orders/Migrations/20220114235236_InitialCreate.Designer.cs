﻿// <auto-generated />
using Food_Orders.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Food_Orders.Migrations
{
    [DbContext(typeof(FoodOrdersContext))]
    [Migration("20220114235236_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Food_Orders.Entities.Adresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.Property<string>("Oras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientID");

                    b.ToTable("Adrese");
                });

            modelBuilder.Entity("Food_Orders.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nr_telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("Food_Orders.Entities.Comanda", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Fel_mancareId")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "Fel_mancareId");

                    b.HasIndex("Fel_mancareId");

                    b.ToTable("Comenzi");
                });

            modelBuilder.Entity("Food_Orders.Entities.Detalii_contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel_fix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel_mobil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("Detalii_contacte");
                });

            modelBuilder.Entity("Food_Orders.Entities.Fel_mancare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cantitate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pret")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Feluri_mancare");
                });

            modelBuilder.Entity("Food_Orders.Entities.Meniu", b =>
                {
                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("Fel_mancareId")
                        .HasColumnType("int");

                    b.HasKey("RestaurantId", "Fel_mancareId");

                    b.HasIndex("Fel_mancareId");

                    b.ToTable("Meniuri");
                });

            modelBuilder.Entity("Food_Orders.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specific")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip_pret")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurante");
                });

            modelBuilder.Entity("Food_Orders.Entities.Adresa", b =>
                {
                    b.HasOne("Food_Orders.Entities.Client", "Client")
                        .WithMany("Adrese")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Food_Orders.Entities.Comanda", b =>
                {
                    b.HasOne("Food_Orders.Entities.Client", "Client")
                        .WithMany("Comenzi")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food_Orders.Entities.Fel_mancare", "Fel_mancare")
                        .WithMany("Comenzi")
                        .HasForeignKey("Fel_mancareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Fel_mancare");
                });

            modelBuilder.Entity("Food_Orders.Entities.Detalii_contact", b =>
                {
                    b.HasOne("Food_Orders.Entities.Restaurant", "Restaurant")
                        .WithOne("Detalii_Contact")
                        .HasForeignKey("Food_Orders.Entities.Detalii_contact", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Food_Orders.Entities.Meniu", b =>
                {
                    b.HasOne("Food_Orders.Entities.Fel_mancare", "Fel_mancare")
                        .WithMany("Meniuri")
                        .HasForeignKey("Fel_mancareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food_Orders.Entities.Restaurant", "Restaurant")
                        .WithMany("Meniuri")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fel_mancare");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Food_Orders.Entities.Client", b =>
                {
                    b.Navigation("Adrese");

                    b.Navigation("Comenzi");
                });

            modelBuilder.Entity("Food_Orders.Entities.Fel_mancare", b =>
                {
                    b.Navigation("Comenzi");

                    b.Navigation("Meniuri");
                });

            modelBuilder.Entity("Food_Orders.Entities.Restaurant", b =>
                {
                    b.Navigation("Detalii_Contact");

                    b.Navigation("Meniuri");
                });
#pragma warning restore 612, 618
        }
    }
}