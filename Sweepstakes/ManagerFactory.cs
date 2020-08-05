using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory : ICreateManagers
    {
        public ISweepstakesManager SelectManager()
        {
            string[] choices = { "1.) Queue", "2.) Stack" };
            UserInterface.PrintSelections(choices);
            char type = UserInterface.GetMenuInputFor("Select manager type: ");
            switch (type)
            {
                case '1':
                    UserInterface.PrintStatus("Queue Management Selected");
                    return new SweepstakesQueueManager();
                case '2':
                    UserInterface.PrintStatus("Stack Management Selected");
                    return new SweepstakesStackManager();
                default:
                    UserInterface.PrintStatus("Incorrect selection entered. Try Again");
                    return SelectManager();
            }
        }
    }
}
