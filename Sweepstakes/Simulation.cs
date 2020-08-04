using System;
using System.Collections.Generic;
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
            ISweepstakesManager manager = new ManagerFactory().SelectManager();
            firm = new MarketingFirm(manager);
        }

        public void MainMenu()
        {
            string[] choices = { "1.) Create Sweepstakes", "2.) Open Sweepstakes" };
            UserInterface.PrintSelections(choices);
            char type = UserInterface.GetMenuInputFor("Select an Action: ");
            switch (type)
            {
                case '1':
                    firm.CreateSweeptakes();
                    break;
                case '2':
                    SweepstakesMenu(firm.Manager.GetSweepstakes());
                    break;
                default:
                    Console.Write("\t[Not a valid choice!]");
                    MainMenu();
                    break;
            }

        }

        public void SweepstakesMenu(Sweepstakes sweepstakes)
        {
            string[] choices = { "1.) Add Contestant", "2.) View Contestants", "3.) Pick Winner", "4.) Return to Main" };
            UserInterface.PrintSelections(choices);
            char type = UserInterface.GetMenuInputFor("Select an Action: ");
            switch (type)
            {
                case '1':
                    sweepstakes.RegisterContestant();
                    SweepstakesMenu(sweepstakes);
                    break;
                case '2':
                    sweepstakes.PrintContestants();
                    Console.ReadLine();
                    SweepstakesMenu(sweepstakes);
                    break;
                case '3':
                    sweepstakes.PickWinner();
                    SweepstakesMenu(sweepstakes);
                    break;
                case '4':
                    sweepstakes.PrintContestants();
                    MainMenu();
                    break;
                default:
                    Console.Write("\t[Not a valid choice!]");
                    SweepstakesMenu(sweepstakes);
                    break;
            }
        }




    }
}
