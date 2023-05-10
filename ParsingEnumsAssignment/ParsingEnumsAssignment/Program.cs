using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("User! Enter the current day of the week, ex. Monday");
                string answer = Console.ReadLine();
                DaysOfTheWeek day;
                if (Enum.TryParse(answer, out day))
                {
                    Console.WriteLine(day);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
        
    }
}
