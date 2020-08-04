using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get => name;
        }

        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            Console.WriteLine("Please enter first name: ");
            UserInter
        }

        public void PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
