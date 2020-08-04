using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public Simulation()
        {
            UserInterface.PrintApplicationHeader();
            CreateMarketingFirmWithManager();


            UserInterface.GetMenuInputFor("Select an Action: ");

        }


        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager = new ManagerFactory().SelectManager();
            MarketingFirm firm = new MarketingFirm(manager);
        }
    }
}
