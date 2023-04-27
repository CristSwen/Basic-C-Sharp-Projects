using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What's your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False' ");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study");
            string studyHours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            

        }
    }
}
