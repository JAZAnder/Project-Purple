using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace LearningStarter.Entities
{
    public class Golem
    {
        public int Id { get; set; }
        public string Henry { get; set; }

        public List<GolemSpell> GolemSpells { get; set; }
            = new List<GolemSpell>(3);


        public int GolemTypeId { get; set; }
        public GolemType GolemType { get; set; }


        public int? TargetGolemId { get; set; }
        public Golem TargetGolem { get; set; }

        
    }
}
