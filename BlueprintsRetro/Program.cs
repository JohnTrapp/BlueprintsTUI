using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueprintsRetro
{
    class Program
    {
        private static Queue<String> consoleLines = new Queue<String>();
        private static StatsManager statsManager;
        static void Main(string[] args)
        {
            //Setup
            Console.Title = "Blueprints College Time Manager";

            Console.WindowWidth = 110;
            Console.WindowHeight = 29;

            Console.BufferWidth = 110;
            Console.BufferHeight = 29;

            //statsManager = new StatsManager();

            while (true)
            {
                //Clear the display
                Console.Clear();

                //Draw the display
                Print();

                //Game logic
                AddLine(Console.ReadLine());
            }
        }

        private static void AddLine(string input)
        {
            string theString = input;
            if (consoleLines.Count == 24)
            {
                //If size of array is greater than 24, discard the oldest entry.
                consoleLines.Dequeue();
            }
            if (theString.Length > 100)
            {
                theString = "Error: Buffer Overflow.";
            }
            else if (theString.Length == 0)
            {
                theString = "Error: No command entered.";
            }
            else
            {
                try
                {
                    DecodeInput(theString);
                }
                catch (CommandNotRecognized e)
                {
                    theString = "Command \"" + e + "\" not recognized.";
                }
            }

            consoleLines.Enqueue(theString);
        }

        private static void DecodeInput(string theString) => new CommandRunner(theString);

        private static void Print()
        {
            Console.WriteLine("+--CONSOLE------------------------------------------------------------------------------------+ +---STATS---+");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |Time:      |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |Happiness: |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |Study:     |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |Health:    |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |Sleep:     |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("+---------------------------------------------------------------------------------------------+ |           |");
            Console.WriteLine("|                                                                                             | |           |");
            Console.WriteLine("+---------------------------------------------------------------------------------------------+ +-----------+");

            PrintStats();
            PrintText();

            Console.SetCursorPosition(2, 26);
        }

        private static void PrintStats()
        {
            Console.SetCursorPosition(100, 7);
            Console.Write(StatsManager.Instance.Happiness);

            Console.SetCursorPosition(100, 10);
            Console.Write(StatsManager.Instance.Study);

            Console.SetCursorPosition(100, 13);
            Console.Write(StatsManager.Instance.Health);

            Console.SetCursorPosition(100, 16);
            Console.Write(StatsManager.Instance.Sleep);
        }

        private static void PrintText()
        {
            int count = 24;
            Console.SetCursorPosition(2, 24);

            String[] array = new String[consoleLines.Count];
            consoleLines.CopyTo(array, 0);
            array.Reverse();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
                Console.SetCursorPosition(2, --count);
            }
        }
    }
}