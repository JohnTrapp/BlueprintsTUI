namespace BlueprintsRetro
{
    class StudyCommand : Command
    {
        public void RunCommand() {
            StatsManager.Instance.Study++;
            StatsManager.Instance.Sleep--;
        }
    }
}