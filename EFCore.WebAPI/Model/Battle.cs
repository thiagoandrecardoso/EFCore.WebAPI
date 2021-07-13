using System;
using System.Collections.Generic;

namespace EFCore.WebAPI.Model
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DtInitial { get; set; }
        public DateTime DtEnd { get; set; }
        public List<HeroBattleManyToMany> HerosBattles { get; set; }
    }
}