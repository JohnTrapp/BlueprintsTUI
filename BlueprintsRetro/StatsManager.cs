namespace BlueprintsRetro
{
    internal class StatsManager
    {
        public int Happiness { get; set; }
        public int Study { get; set; }
        public int Health { get; set; }
        public int Sleep { get; set; }

        public StatsManager()
        {
            Happiness = 0;
            Study = 0;
            Health = 0;
            Sleep = 0;
        }
    }
}