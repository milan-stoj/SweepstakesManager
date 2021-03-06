﻿using System;
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
            string[] choices = { "1.) Queue Method (FIFO)", "2.) Stack Method (FILO)" };
            UserInterface.PrintSelections(choices);
            char type = UserInterface.GetMenuInputFor("Select Management Type: ");
            switch (type)
            {
                case '1':
                    UserInterface.PrintStatus("Queue Management Method Selected (FIFO)");
                    return new SweepstakesQueueManager();
                case '2':
                    UserInterface.PrintStatus("Stack Management Method Selected (FILO)");
                    return new SweepstakesStackManager();
                default:
                    UserInterface.PrintStatus("Incorrect selection entered. Try Again");
                    return SelectManager();
            }
        }
    }
}
