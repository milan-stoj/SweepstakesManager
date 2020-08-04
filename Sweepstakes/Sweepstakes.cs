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
        int registrationNumber;
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
            contestant = new Contestant(
                UserInterface.GetUserInputFor("First Name"),
                UserInterface.GetUserInputFor("Last Name"),
                UserInterface.GetUserInputFor("Email Address"),
                Convert.ToInt32(UserInterface.GetUserInputFor("Registration Number")));
            
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public void PickWinner()
        {
            List<int> listOfKeys = new List<int>(contestants.Keys);
            Random rand = new Random();
            int randomKey = listOfKeys[rand.Next(listOfKeys.Count)];
            Contestant winner = contestants[randomKey];
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
