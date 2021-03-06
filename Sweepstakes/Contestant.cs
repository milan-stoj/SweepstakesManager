﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   class Contestant : IContestant 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }

        public Contestant(string FirstName, string LastName, string EmailAddress, int RegistrationNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.RegistrationNumber = RegistrationNumber;
        }

        public void Notify(IContestant contestant)
        {
            Console.Write("Sorry {0} You have lost the sweepstakes!\n", contestant.FirstName);
        }

    }
}
