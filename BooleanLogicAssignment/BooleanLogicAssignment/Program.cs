using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user their age and converting it into a int
            Console.WriteLine("What is your age?");
            string enterAge = Console.ReadLine();
            int age = Convert.ToInt32(enterAge);

            //Asking the user a yes or no question for DUI's
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();

            //Taking the asnwer of speeding tickets and converting it into a int
            Console.WriteLine("How many speeding tickets do you have?");
            string enterTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(enterTickets);

            //Seeing if the User is 15 or older, has no DUI's and has 3 or less tickets
            bool qualifications = (age >= 15 && dui == "no" && tickets <= 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualifications);
            Console.ReadLine();
        }
    }
}
