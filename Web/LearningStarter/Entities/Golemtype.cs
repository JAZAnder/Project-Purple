using System.Collections.Generic;

namespace LearningStarter.Entities
{
    public class GolemType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Maxhealth { get; set; }
        
        public List<GolemSpell> GolemSpells { get; set; }
            = new List<GolemSpell>();
    }
}
