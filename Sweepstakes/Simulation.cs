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
            UserInterface.PrintApplicationHeader();
            CreateMarketingFirmWithManager();
            MainMenu();
        }


        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = new ManagerFactory().SelectManager();
            firm = new MarketingFirm(manager);
        }

        public void MainMenu()
        {
            string[] choices = { "1.) Create Sweepstakes", "2.) View Sweepstakes" };
            UserInterface.PrintSelections(choices);
            char type = UserInterface.GetMenuInputFor("Select an Action: ");
            switch (type)
            {
                case '1':
                    firm.CreateSweeptakes();
                    break;
                case '2':
                    firm._manager.GetSweepstakes();
                default:
                    Console.Write("\t[Not a valid choice!]");
                    MainMenu();
            }

        }




    }
}
