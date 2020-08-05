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
            string[] choices = { "1.) Create Sweepstakes", "2.) Start Next Sweepstakes" };
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
                        UserInterface.PrintStatus("No sweepstakes have been created. Create a sweepstakes first");
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
            string[] choices = { "1.) Add Contestant", "2.) View Contestant", "3.) Pick Winner" };
            UserInterface.PrintSelections(choices);
            char type = UserInterface.GetMenuInputFor("Select an Action: ");
            switch (type)
            {
                case '1':
                    sweepstakes.RegisterContestant();
                    SweepstakesMenu(sweepstakes);
                    break;
                case '2':
                    SweepstakesMenu(sweepstakes);
                    break;
                case '3':
                    sweepstakes.PickWinner();
                    SweepstakesMenu(sweepstakes);
                    break;
                default:
                    SweepstakesMenu(sweepstakes);
                    break;
            }
        }




    }
}
