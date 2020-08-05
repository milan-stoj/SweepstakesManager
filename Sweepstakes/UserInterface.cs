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

        public static void PrintContestantInfo(Dictionary<int, IContestant> contestants)
        {
            Console.WriteLine($"\nReg. # \tFirst Name");
            Console.WriteLine($"---------------------------------");
            foreach (KeyValuePair<int, IContestant> contestant in contestants)
            {
                Console.WriteLine($"{contestant.Value.RegistrationNumber} \t{contestant.Value.FirstName}");
            }
        }


        public static void PrintWinner(IContestant winner)
        {
            ClearPrintingArea();
            SetPrintingCursorPosition();
            Console.WriteLine($"WINNER! {winner.FirstName}");
            Console.WriteLine($"Last Name: {winner.LastName}");
            Console.WriteLine($"Email: {winner.EmailAddress}");
            Console.WriteLine($"Registration: {winner.RegistrationNumber}");
            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"Press enter to send notifications, close the sweepstakes, and return to main sweepstakes menu.");
            Console.ReadLine();
        }

        public static void SendNotifications(Dictionary<int, IContestant> contestants)
        {
            ClearPrintingArea();
            SetPrintingCursorPosition();
            foreach (KeyValuePair<int, IContestant> contestant in contestants)
            {
                Console.Write($"Message to {contestant.Value.EmailAddress}: \t");
                contestant.Value.Notify(contestant.Value);
            }
            Console.ReadLine();
        }


        public static void PrintContestantInfo(IContestant contestant)
        {
            ClearPrintingArea();
            SetPrintingCursorPosition();
            Console.WriteLine($"Info for contestant {contestant.FirstName}");
            Console.WriteLine($"Last Name: {contestant.LastName}");
            Console.WriteLine($"Email: {contestant.EmailAddress}");
            Console.WriteLine($"Registration: {contestant.RegistrationNumber}");
            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"Press enter to return to sweepstakes menu");
            Console.ReadLine();
        }

        public static void PrintSweepstakes(Stack<Sweepstakes> stack)
        {
            Console.WriteLine("\nCurrently Pending Sweepstakes (FILO): ");
            foreach (Sweepstakes sweepstakes in stack)
            {
                Console.WriteLine(sweepstakes.Name);
            }
        }

        public static void PrintSweepstakes(Queue<Sweepstakes> queue)
        {
            Console.WriteLine("\nCurrently Pending Sweepstakes (FIFO): ");
            foreach (Sweepstakes sweepstakes in queue)
            {
                Console.WriteLine(sweepstakes.Name);
            }
        }
    }
}
