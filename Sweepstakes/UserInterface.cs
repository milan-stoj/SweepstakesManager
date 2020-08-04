using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void PrintSelections(string[] choices)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 16);
            foreach (string choice in choices)
            {
                Console.WriteLine(choice);
            }
        }

        public static void PrintSelections(Queue<Sweepstakes> queue)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 16);
            foreach (Sweepstakes sweepstakes in queue)
            {
                Console.WriteLine($"{sweepstakes.Name}");
            }
        }

        public static string GetUserInputFor(string prompt)
        {
            ResetCursorPosition();
            ClearCurrentConsoleLine();
            Console.Clear();
            Console.Write($"{prompt}");
            return Console.ReadLine();
        }

        public static char GetMenuInputFor(string prompt)
        {
            ResetCursorPosition();
            ClearCurrentConsoleLine();
            Console.Write($"{prompt}");
            return Console.ReadKey().KeyChar;
        }

        private static void ResetCursorPosition()
        {
            Console.SetCursorPosition(0, 15);
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void PrintContestantInfo(Contestant contestant)
        {
            Console.Clear();
            ResetCursorPosition();
            ClearCurrentConsoleLine();
            Console.WriteLine($"First name:     {contestant.FirstName}");
            Console.WriteLine($"Last name:      {contestant.LastName}");
            Console.WriteLine($"Email address:  {contestant.FirstName}");
            Console.WriteLine($"Registration #: {contestant.RegistrationNumber}");

        }

    }
}
