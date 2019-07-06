using System;

namespace BlueprintsRetro
{
    interface Command
    {
        void RunCommand();
    }

    interface CommandFactory
    {
        Command GetCommand(String strFullyQualifiedName);
    }

    class CommandRunner : CommandFactory
    {
        public CommandRunner(String strFullyQualifiedName)
        {
            try { GetCommand(strFullyQualifiedName).RunCommand(); }
            catch
            {
                new CommandNotRecognized();
            }
        }
        public Command GetCommand(string strFullyQualifiedName)
        {
            Type t = Type.GetType(strFullyQualifiedName);
            return (Command)Activator.CreateInstance(t);
        }
    }
}