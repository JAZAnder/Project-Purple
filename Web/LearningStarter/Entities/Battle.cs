namespace LearningStarter.Entities
{
    public class Battle
    {
        public int Id { get; set; }
        public int PlayerOneId { get; set; }
        public User PlayerOne { get; set; }

        public int PlayerOneGolemId { get; set; }
        public Golem PlayerOneGolem { get; set; }
        public int PlayerOneGolemHealth {get; set; }

        public int PlayerTwoId { get; set; }
        public User PlayerTwo { get; set; }

        public int PlayerTwoGolemId { get; set; }
        public Golem PlayerTwoGolem { get; set; }
        public int PlayerTwoGolemHealth { get; set; }
    }
}
