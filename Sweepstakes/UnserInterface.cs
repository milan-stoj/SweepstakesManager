using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UnserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.Write("Enter the {0}:", prompt);
            return Console.ReadLine();
        }
    }
}
