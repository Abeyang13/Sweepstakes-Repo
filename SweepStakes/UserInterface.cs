using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class User_Interface
    {

        public static void GetContestantInformation(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter your email address");
            contestant.email = Console.ReadLine();
            Console.WriteLine("Please enter your registration number(Numbers Only)");
            int.TryParse(Console.ReadLine(), out contestant.registrationNumber);
        }
    }
}
