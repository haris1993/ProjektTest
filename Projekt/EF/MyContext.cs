using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.EF
{
    public class MyContext:DbContext
    {
        public DbSet<Kupac> Kupac { get; set; }
        public DbSet<SelectListItems> Opstina { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<StavkaFakture> StavkaFakture { get; set; }
        public DbSet<Faktura> Faktura { get; set; }
        public DbSet<Admin> Admin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=projekt;trusted_connection=true;");
        }
    }
}
