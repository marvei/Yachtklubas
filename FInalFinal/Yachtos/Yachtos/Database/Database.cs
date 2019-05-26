using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Yachtos.Models
{
    public class DatabaseContext : DbContext
    {
           //CIa reikia rasyti tuos tokius Tables nu klases vienu zodziu.

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=Yachtos.db");
            }

    }
}
