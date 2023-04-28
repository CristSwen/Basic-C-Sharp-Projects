using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What's your hourly rate?");
            string per1Hourly = Console.ReadLine();
            decimal hourly1Per = Convert.ToDecimal(per1Hourly);
            Console.WriteLine("How many hours did you work this week?");
            string per1Weekly = Console.ReadLine();
            int weekly1Per = Convert.ToInt32(per1Weekly);


            Console.WriteLine("Person 2");
            Console.WriteLine("What's your hourly rate?");
            string per2Hourly = Console.ReadLine();
            decimal hourly2Per = Convert.ToDecimal(per2Hourly);
            Console.WriteLine("How many hours did you work this week?");
            string per2Weekly = Console.ReadLine();
            int weekly2Per = Convert.ToInt32(per2Weekly);

            
            decimal hourlyByWeekly1 = hourly1Per * weekly1Per * 52;
            decimal hourlyByWeekly2 = hourly2Per * weekly2Per * 52;
            bool compare = hourlyByWeekly1 > hourlyByWeekly2;

            Console.WriteLine("Annual salary of Person1: ");
            Console.WriteLine(hourlyByWeekly1);
            Console.WriteLine("Annual salary of Person2: ");
            Console.WriteLine(hourlyByWeekly2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compare);
            Console.ReadLine();
        }
    }
}
