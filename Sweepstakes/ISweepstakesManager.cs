﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface ISweepstakesManager
    {

        void InsertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();

        void ViewSweepstakes();

        int SweepStakesCount();

        void CloseSweepstakes();
    }
}
