namespace LearningStarter.Entities
{
    public class Spell
    {
        public int Id { get; set; }
        public string SpellName { get; set; }
        public string Description { get; set; }

        public int ChanceId { get; set; }
        public Chance Chance { get; set; }

        public int DamageDealt { get; set; }
        public int DamageRecived { get; set; }
    }
}