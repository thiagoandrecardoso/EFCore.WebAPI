using System.Collections.Generic;

namespace EFCore.Domain
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecretIdentity Secret { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<HeroBattleManyToMany> HerosBattles { get; set; }
    } 
}