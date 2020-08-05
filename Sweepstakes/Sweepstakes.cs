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
        Dictionary<int, IContestant> contestants;

        public string Name { get; }

        public Sweepstakes(string name)
        {
            registrationNumber = 1000;
            Name = name;
            contestants = new Dictionary<int, IContestant>();
        }

        public void RegisterContestant()
        {
            Contestant contestant = new Contestant(
                UserInterface.GetUserInputFor("First Name: "),
                UserInterface.GetUserInputFor("Last Name: "),
                UserInterface.GetUserInputFor("Email Address: "),
                registrationNumber);
            registrationNumber++;
            
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public void PickWinner()
        {
            List<int> listOfKeys = new List<int>(contestants.Keys);
            Random rand = new Random();
            int randomKey = listOfKeys[rand.Next(listOfKeys.Count)];
            contestants[randomKey] = new Winner(contestants[randomKey]);
        }

        public void PrintContestantInfo(IContestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant);
        }
    }
}
