using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercicioClase3Modulo2EFCore.Entities;

// Data/ApplicationDbContext.cs


namespace EjercicioClase3Modulo2EFCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O2TG6DB\SQLEXPRESS;Database=SimpleIMDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}