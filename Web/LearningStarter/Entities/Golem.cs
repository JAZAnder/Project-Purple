using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace LearningStarter.Entities
{
    public class Golem
    {
        public int Id { get; set; }

        public int Health { get; set; }

        public Spell[] Spells { get; set; }
    }
}
