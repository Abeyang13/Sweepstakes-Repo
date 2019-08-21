using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class User_Interface
    {

        public static string GetContestantFirstName()
        {
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string GetContestantLastName()
        {
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string GetContestantEmail()
        {
            Console.WriteLine("Please enter your email address");
            string email = Console.ReadLine();
            return email;
        }
        public static int GetContestantRegistrationNumber()
        { 
            Console.WriteLine("Please enter your registration number(Numbers Only)");
            int registrationNumber;
            int.TryParse(Console.ReadLine(), out registrationNumber);
            return registrationNumber;
        }
        public static string AskForManager()
        {
            Console.WriteLine("Did you want to run a Stack Or Queue for managing your Sweepstakes?  Please input Stack or Queue");
            return Console.ReadLine().ToLower();
        }
    }
}
