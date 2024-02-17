using FutsalTeam.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Persistanc
{
    public class EFDataContext :DbContext
    {
        public DbSet<Team> Teams { get; set; }  
        public DbSet<Player> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TeamDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
