using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
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
            contestant.CreateContestant();
            contestInfo.Add(contestant.registrationNumber, contestant);
        }
        public string PickWinner()
        {
            Random rng = new Random();
            Contestant win = contestInfo[rng.Next(contestInfo.Count)];
            string winningContestant = win.firstName + " " + win.lastName;
            PrintContestantInfo(win);
            return winningContestant;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.email);
            Console.WriteLine(contestant.registrationNumber);
        }
    }
}
