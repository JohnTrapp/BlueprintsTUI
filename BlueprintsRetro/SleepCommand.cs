namespace BlueprintsRetro
{
    class SleepCommand : Command
    {
        public void RunCommand() {
            StatsManager.Instance.Sleep++;
        }
    }
}