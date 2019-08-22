using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class FactoryManager
    {
        public static ISweepstakesManager PickManager(string manager)
        {
            ISweepstakesManager user = null;
            switch (manager)
            {
                case "stack":
                    user = new SweepstakesStackManager();
                    break;
                case "queue":
                    user = new SweepstakesQueueManager();
                    break;
                default:
                    return PickManager(User_Interface.AskForManager()); ;
            }
            return user;
        }
    }
}
