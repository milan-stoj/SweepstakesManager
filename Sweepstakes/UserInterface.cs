using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static void PrintSelections(string[] choices)
        {
            SetPrintingCursorPosition();
            foreach (string choice in choices)
            {
                Console.WriteLine(choice);
            }
        }

        public static void PrintSelections(Queue<Sweepstakes> queue)
        {
            SetPrintingCursorPosition();
            foreach (Sweepstakes sweepstakes in queue)
            {
                Console.WriteLine($"{sweepstakes.Name}");
            }
        }

        public static string GetUserInputFor(string prompt)
        {
            SetInputCursorPosition();
            Console.Write($"{prompt}");
            return Console.ReadLine();
        }

        public static char GetMenuInputFor(string prompt)
        {
            SetInputCursorPosition();
            Console.Write($"{prompt}");
            return Console.ReadKey().KeyChar;
        }

        public static void SetPrintingCursorPosition()
        {
            ClearPrintingArea();
            Console.SetCursorPosition(0, 5);
        }

        public static void PrintStatus(string status)
        {
            Console.SetCursorPosition(0, 0);
            ClearCurrentConsoleLine();
            Console.Write($"{status}");
        }

        private static void SetInputCursorPosition()
        {
            Console.SetCursorPosition(0, 3);
            ClearCurrentConsoleLine();
        }

        public static void ClearPrintingArea()
        {
            for (int h = 0; h < Console.WindowHeight; h++)
            {
                Console.SetCursorPosition(0, h + 5);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, h + 5);
            }
            Console.SetCursorPosition(0, 0);
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void PrintContestantInfo(IContestant contestant)
        {
            ClearPrintingArea();
            Console.WriteLine($"First name:     {contestant.FirstName}");
            Console.WriteLine($"Last name:      {contestant.LastName}");
            Console.WriteLine($"Email address:  {contestant.FirstName}");
            Console.WriteLine($"Registration #: {contestant.RegistrationNumber}");
        }

        public static void PrintSweepstakes(Stack<Sweepstakes> stack)
        {
            Console.WriteLine("\nCurrently Opened Sweepstakes: ");
            foreach (Sweepstakes sweepstakes in stack)
            {
                Console.WriteLine(sweepstakes.Name);
            }
        }

        public static void PrintSweepstakes(Queue<Sweepstakes> queue)
        {
            Console.WriteLine("\nCurrently Opened Sweepstakes: ");
            foreach (Sweepstakes sweepstakes in queue)
            {
                Console.WriteLine(sweepstakes.Name);
            }
        }
    }
}
