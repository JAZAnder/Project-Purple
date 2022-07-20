namespace LearningStarter.Entities
{
    public class GolemSpell
    {
        public int Id {get; set;}
        public int SpellId {get; set;}
        public Spell Spell {get; set;}

        public int GolemId {get; set;}
        public Golem Golem {get; set;}
     }
}
