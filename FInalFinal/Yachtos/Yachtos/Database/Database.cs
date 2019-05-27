using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Yachtos.Models;

namespace Yachtos.Database
{
    public class DatabaseContext : DbContext
    {
           //CIa reikia rasyti tuos tokius Tables nu klases vienu zodziu.

        public DbSet<Yachtos.Models.User> User { get; set; }
        public DbSet<Yachtos.Models.Items> Items { get; set; }
        public DbSet<Yachtos.Models.Storage> Storage { get; set; }
        public DbSet<Yachtos.Models.Packages> Packages { get; set; }
        public DbSet<Yachtos.Models.PackagesItems> PackagesItems { get; set; }
        public DbSet<Yachtos.Models.Employee> Employee { get; set; }
        public DbSet<Yachtos.Models.Cart> Cart { get; set; }
        public DbSet<Yachtos.Models.Order> Order { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=Yachtos.db");
            }



        public DbSet<Yachtos.Models.Favorites> Favorites { get; set; }



    }
}
