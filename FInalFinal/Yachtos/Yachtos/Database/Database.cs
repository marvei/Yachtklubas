using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Yachtos.Database
{
    public class DatabaseContext : DbContext
    {
           //CIa reikia rasyti tuos tokius Tables nu klases vienu zodziu.

            public DbSet<Yachtos.Models.User> User { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=Yachtos.db");
            }



    }
}
