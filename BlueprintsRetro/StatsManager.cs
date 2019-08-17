namespace BlueprintsRetro
{
    internal class StatsManager
    {
        private static readonly StatsManager instance = new StatsManager();
        public int Happiness { get; set; }
        public int Study { get; set; }
        public int Health { get; set; }
        public int Sleep { get; set; }

        static StatsManager() { }

        private StatsManager()
        {
            Happiness = 0;
            Study = 0;
            Health = 0;
            Sleep = 0;
        }

        public static StatsManager Instance
        {
            get
            {
                return instance;
            }
        }
    }
}