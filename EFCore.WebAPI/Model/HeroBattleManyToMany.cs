﻿namespace EFCore.WebAPI.Model
{
    public class HeroBattleManyToMany
    {
        public int HeroId { get; set; }
        public int BattleId { get; set; }
        public Hero Hero { get; set; }
        public Battle Battle { get; set; }
    }
}