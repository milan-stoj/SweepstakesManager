using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Winner : IContestant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }

        public Winner(IContestant contestant)
        {
            FirstName = contestant.FirstName;
            LastName = contestant.LastName;
            EmailAddress = contestant.EmailAddress;
            RegistrationNumber = contestant.RegistrationNumber;
        }
        public void Notify(IContestant contestant)
        {
            Console.Write("Congratulations {0} You have won the sweepstakes!\n", contestant.FirstName);
        }
    }
}
