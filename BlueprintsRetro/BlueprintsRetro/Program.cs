using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueprintsRetro
{
    class Program
    {
        private static Queue<String> consoleLines = new Queue<String>();
        static void Main(string[] args)
        {
            //Setup
            Console.Title = "Blueprints College Time Manager";

            Console.WindowWidth = 110;
            Console.WindowHeight = 29;

            Console.BufferWidth = 110;
            Console.BufferHeight = 29;

            while (true) {
                //Clear the display
                Console.Clear();

                //Draw the display
                Print();

                //Game logic
                AddLine(Console.ReadLine());
            }
        }

        private static void AddLine(string v)
        {
            if(consoleLines.Count == 24) {
                consoleLines.Dequeue();
            }
            consoleLines.Enqueue(v);
        }

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

            PrintText();

            Console.SetCursorPosition(2,26);
        }

        private static void PrintText()
        {
            int count = 24;
            Console.SetCursorPosition(2, 24);

            String[] array = new String[consoleLines.Count];
            consoleLines.CopyTo(array, 0);
            array.Reverse();
            for(int i = array.Length - 1; i >=0 ; i--) {
                Console.Write(array[i]);
                Console.SetCursorPosition(2, --count);
            }
        }
    }
}
