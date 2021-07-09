using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class HeroContext : DbContext
    {
        public const string StrComm = "Password=abacaxi98;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=WDAELETRA02\\SQLEXPRESS";
        public DbSet<Hero> Heros { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StrComm);
        }
    }
}
