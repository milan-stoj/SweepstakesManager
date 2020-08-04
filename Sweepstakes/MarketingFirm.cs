using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager _manager;

        // constructor injection
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweeptakes()
        {
            Sweepstakes sweepStakes = new Sweepstakes(UserInterface.GetUserInputFor("Sweepstakes Name"));
        }
    }
}
