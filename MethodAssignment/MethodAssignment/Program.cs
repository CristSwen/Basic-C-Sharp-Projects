using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers integers = new Integers();
            Console.WriteLine("Please enter a number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number if you wish");
            string secondEnter = Console.ReadLine();
            int secondNum = 0;
            //If second number is empty it will continue the code
            if (!string.IsNullOrEmpty(secondEnter))
            {
                secondNum = Convert.ToInt32(secondEnter);
            }
            int result = integers.IntMethod(firstNum, secondNum);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
