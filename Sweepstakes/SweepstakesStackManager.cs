using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;

        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Peek();
        }

        public void ViewSweepstakes()
        {
            UserInterface.PrintSweepstakes(stack);
        }

        public void CloseSweepstakes()
        {
            stack.Pop();
        }

        public int SweepStakesCount()
        {
            return stack.Count();
        }
    }
}
