using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void PrintApplicationHeader()
        {
            string welcomeMessage = "Welceom to the sweepstakes manager.";
            Console.WriteLine(welcomeMessage);
        }

        public static void PrintSelections(string[] choices)
        {
            Console.SetCursorPosition(0, 20);
            foreach (string choice in choices)
            {
                Console.WriteLine(choice);
            }
            Console.SetCursorPosition(0, 19);
        }

        public static string GetUserInputFor(string prompt)
        {
            Console.Write($"{prompt}");
            return Console.ReadLine();
        }

        public static char GetMenuInputFor(string prompt)
        {
            Console.Write($"{prompt}");
            return Console.ReadKey().KeyChar;
        }

    }
}
