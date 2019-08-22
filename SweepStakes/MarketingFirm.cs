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


        public MarketingFirm()
        {
            sweepstakesManager = ValueOfManager();
        }
        public ISweepstakesManager ValueOfManager()
        {           
            return FactoryManager.PickManager(User_Interface.AskForManager());       
        }
    }
}
