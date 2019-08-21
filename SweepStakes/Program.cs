using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ISweepstakesManager manager = FactoryManager.PickManager(User_Interface.AskThing());
            MarketingFirm thing = new MarketingFirm(manager);           
        }
    }
}
