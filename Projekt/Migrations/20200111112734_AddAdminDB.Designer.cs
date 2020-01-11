﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt.EF;

namespace Projekt.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200111112734_AddAdminDB")]
    partial class AddAdminDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projekt.Models.Faktura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.ToTable("Faktura");
                });

            modelBuilder.Entity("Projekt.Models.Kupac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpstinaPrebivalistaId")
                        .HasColumnType("int");

                    b.Property<int>("OpstinaRodjenjaId")
                        .HasColumnType("int");

                    b.Property<string>("PDVBroj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OpstinaPrebivalistaId");

                    b.HasIndex("OpstinaRodjenjaId");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("Projekt.Models.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<string>("JedinicaMjere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("Projekt.Models.SelectListItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Drzava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("Projekt.Models.StavkaFakture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("FakturaId")
                        .HasColumnType("int");

                    b.Property<float>("Kolicina")
                        .HasColumnType("real");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FakturaId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("StavkaFakture");
                });

            modelBuilder.Entity("Projekt.Models.Faktura", b =>
                {
                    b.HasOne("Projekt.Models.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekt.Models.Kupac", b =>
                {
                    b.HasOne("Projekt.Models.SelectListItems", "OpstinaPrebivalista")
                        .WithMany()
                        .HasForeignKey("OpstinaPrebivalistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt.Models.SelectListItems", "OpstinaRodjenja")
                        .WithMany()
                        .HasForeignKey("OpstinaRodjenjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekt.Models.StavkaFakture", b =>
                {
                    b.HasOne("Projekt.Models.Faktura", "Faktura")
                        .WithMany()
                        .HasForeignKey("FakturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
