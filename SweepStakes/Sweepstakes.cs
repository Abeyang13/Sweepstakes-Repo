using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        






        public void RegisterContestant(Contestant contestant)
        {
            User_Interface.GetContestantInformation(contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            User_Interface.GetContestantInformation(contestant);
        }
        public string PickWinner()
        {

        }
        public void DisplayEmployeeIdName()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1337, "Terrill");
            employees.Add(1234, "Heinisch");
            employees.Add(9541, "Carlson");

            Console.Write("Enter an employee name: ");
            string value = Console.ReadLine();
            foreach (KeyValuePair<int, string> employee in employees)
            {
                if (employee.Value == value)
                    Console.WriteLine($"Employee ID: {employee.Key} Employee Name: {employee.Value}");
            }
        }
    }
}
