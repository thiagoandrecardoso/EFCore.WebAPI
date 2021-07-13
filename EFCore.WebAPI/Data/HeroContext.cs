using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI.Data
{
    public class HeroContext : DbContext
    {
        public const string StrComm = "Password=abacaxi98;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=WDAELETRA02\\SQLEXPRESS";
        public DbSet<Hero> Heros { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<HeroBattleManyToMany> HeroBattleMtoM { get; set; }
        public DbSet<SecretIdentity> SecretIdentity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StrComm);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroBattleManyToMany>(entity =>
            {
                entity.HasKey(e => new { e.BattleId, e.HeroId });
            });
        }
    }
}