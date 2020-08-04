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
            CreateMarketingFirmWithManager();


        }


        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager;
            manager = new ISweepstakesManager;
            MarketingFirm firm = new MarketingFirm();
        }
    }
}
