using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;


        public MarketingFirm(ISweepstakesManager manager)
        {
            sweepstakesManager = manager;
        }

        public void Runcontest()
        {
            sweepstakesManager.InsertSweepStakes(new Sweepstakes(new Random(), "Test Sweepstakes"));
        }
    }
}
