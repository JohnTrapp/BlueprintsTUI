using System;

namespace BlueprintsRetro
{
    interface Command
    {
        void RunCommand();
    }

    interface CommandFactory
    {
        Command GetCommand(String str);
    }

    class CommandRunner : CommandFactory
    {
        public CommandRunner(String str)
        {
            try { GetCommand(str).RunCommand(); }
            catch
            {
                new CommandNotRecognized();
            }
        }
        public Command GetCommand(string str)
        {
            switch (str.ToLower())
            {
                case "sleep": return new SleepCommand();
                case "study": return new StudyCommand();
                default:
                    throw new CommandNotRecognized();
            }
            /*Type t = Type.GetType(str);
            return (Command)Activator.CreateInstance(t);*/
        }
    }
}