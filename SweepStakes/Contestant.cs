using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        public Contestant()
        {
            CreateContestant();
        }
        public void CreateContestant()
        {
            firstName = User_Interface.GetContestantFirstName();
            lastName = User_Interface.GetContestantLastName();
            email = User_Interface.GetContestantEmail();
            registrationNumber = User_Interface.GetContestantRegistrationNumber();
        }
    }
}
