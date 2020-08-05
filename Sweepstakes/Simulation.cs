using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        MarketingFirm firm;
        public Simulation()
        {
            CreateMarketingFirmWithManager();
            while (true)
            {
                MainMenu();
            }
        }

        public void CreateMarketingFirmWithManager()
        {
            UserInterface.PrintStatus("Welcome to the Sweepstakes Manager");
            ISweepstakesManager manager = new ManagerFactory().SelectManager();
            firm = new MarketingFirm(manager);
        }

        public void MainMenu()
        {
            string[] choices = { "1.) Create Sweepstakes", "2.) Open Pending Sweepstakes" };
            UserInterface.PrintSelections(choices);
            firm.Manager.ViewSweepstakes();
            char type = UserInterface.GetMenuInputFor("Select an Action: ");
            switch (type)
            {
                case '1':
                    UserInterface.PrintStatus("Creating Sweepstakes");
                    firm.CreateSweeptakes();
                    break;
                case '2':
                    if (firm.Manager.SweepStakesCount() == 0)
                    {
                        UserInterface.PrintStatus("No sweepstakes have been created. Create a sweepstakes first.");
                        MainMenu();
                        break;
                    }
                    SweepstakesMenu(firm.Manager.GetSweepstakes());
                    break;
                default:
                    UserInterface.PrintStatus("Incorrect selection entered. Try Again");
                    MainMenu();
                    break;
            }

        }

        public void SweepstakesMenu(Sweepstakes sweepstakes)
        {
            UserInterface.PrintStatus($"Welcome to the Management Menu for {sweepstakes.Name}");
            string[] choices = { "1.) Add Contestant", "2.) View Contestant", "3.) Pick Winner" };
            UserInterface.PrintSelections(choices);
            sweepstakes.DisplayContestants();
            char type = UserInterface.GetMenuInputFor("Select an Action: ");
            switch (type)
            {
                case '1':
                    sweepstakes.RegisterContestant();
                    SweepstakesMenu(sweepstakes);
                    break;
                case '2':
                    while (true)
                    {
                        string contestant = UserInterface.GetUserInputFor("Enter Registration Number for more info: ");
                        if (sweepstakes.CheckForContestant(contestant) == true)
                        {
                            sweepstakes.PrintContestantInfo(sweepstakes.contestants[Convert.ToInt32(contestant)]);
                            SweepstakesMenu(sweepstakes);
                            break;
                        }
                        else if (sweepstakes.CheckForContestant(contestant) == false)
                        {
                            UserInterface.PrintStatus($"{contestant} was not a valid registration number. Try again");
                        }
                    }
                    break;
                case '3':
                    sweepstakes.PickWinner();
                    firm.Manager.CloseSweepstakes();
                    UserInterface.PrintStatus($"Back to main menu.");
                    break;
                 case '4':
                    UserInterface.PrintStatus($"Back to Main Menu.");
                    break;
                default:
                    SweepstakesMenu(sweepstakes);
                    break;
            }
        }
    }
}
