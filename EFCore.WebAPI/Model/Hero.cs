namespace EFCore.WebAPI.Model
{
    public class Hero
    {
        public int Id { get; set; }
        public Battle Battle { get; set; }
        public string Name { get; set; }
        public int BattleId { get; set; }
    }
}