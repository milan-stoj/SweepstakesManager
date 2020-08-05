using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;

        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
            //UserInterface.DisplayAction();
        }

        public Sweepstakes GetSweepstakes()
        {
            if (queue.Count == 0)
            {
                ;
            }
            UserInterface.PrintSelections(queue);
            return queue.Peek();
        }

        public void ViewSweepstakes()
        {
            UserInterface.PrintSweepstakes(queue);
        }

        public int SweepStakesCount()
        {
            return queue.Count();
        }

    }
}
