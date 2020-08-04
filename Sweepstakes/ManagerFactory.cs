using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory : ICreateManagers
    {
        public ISweepstakesManager SelectManager(string type)
        {
            if (type == "Queue")
            {
                return new SweepstakesQueueManager();
            }
            else
            {
                return new SweepstakesQueueManager();
            }
        }
    }
}
