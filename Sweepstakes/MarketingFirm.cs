using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;

        public ISweepstakesManager Manager
        {
            get => _manager;
        }

        // constructor injection
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweeptakes()
        {
            Console.Clear();
            Sweepstakes sweepStakes = new Sweepstakes(UserInterface.GetUserInputFor("Enter Sweepstakes Name: "));
            _manager.InsertSweepstakes(sweepStakes);
        }
    }
}
