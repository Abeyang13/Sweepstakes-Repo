using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        public string name;
        private string winner;
        private Dictionary<int,Contestant> contestInfo = new Dictionary<int,Contestant>();
        Random random;

        public Sweepstakes(Random random, string name)
        {
            this.random = random;
            this.name = name;
        }



        public void RegisterContestant(Contestant contestant)
        {
            User_Interface.GetContestantInformation(contestant);
            contestInfo.Add(contestant.registrationNumber, contestant);

        }
        public string PickWinner()
        {
            Random rng = new Random();
            string win = contestInfo[rng.Next(contestInfo.Count)].ToString();
            winner = win;
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(winner);
        }
    }
}
