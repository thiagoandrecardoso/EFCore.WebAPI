using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Model
{
    public class HeroBattleManyToMany
    {
        public int HeroId { get; set; }
        public int BattleId { get; set; }
        public Hero Hero { get; set; }
        public Battle Battle { get; set; }

    }
}
