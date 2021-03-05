using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepStakesManager
    {
        Queue<SweepStakes> queue;
        public SweepStakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            throw new NotImplementedException();
        }
    }
}
