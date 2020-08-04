using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string EmailAddress { get; }
        public int RegistrationNumber { get; }

        public Contestant(string FirstName, string LastName, string EmailAddress, int RegistrationNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.RegistrationNumber = RegistrationNumber;
        }
    }
}
