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
        public Dictionary<int, IContestant> contestants;

        public string Name { get; }

        public Sweepstakes(string name)
        {
            registrationNumber = 1000;
            Name = name;
            contestants = new Dictionary<int, IContestant>();
        }

        public void RegisterContestant()
        {
            UserInterface.ClearPrintingArea();
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
            UserInterface.PrintWinner(contestants[randomKey]);
            NotifyContestents();
        }

        public void DisplayContestants()
        {
            UserInterface.PrintContestantInfo(contestants);
        }

        public bool CheckForContestant(string key)
        {
            bool newKey = int.TryParse(key, out int keyInt);
            return newKey && contestants.ContainsKey(keyInt);
        }

        public void PrintContestantInfo(IContestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant);
        }

        public void NotifyContestents()
        {
            UserInterface.SendNotifications(contestants);
        }

    }
}
