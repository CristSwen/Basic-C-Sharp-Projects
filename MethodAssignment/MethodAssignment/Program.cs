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
            //The second readline is placed inside the try block to see if all is good.
            //If a second number is entered, the method will run passing both numbers in
            try
            {
                string secondEnter = Console.ReadLine();
                int secondNum = Convert.ToInt32(secondEnter);
                Console.WriteLine(integers.IntMethod(firstNum, secondNum));
            }
            //If the user did not enter in a number, but entered nothing, symbols, or letters, it will only pass the firstNum
            catch
            {
                Console.WriteLine(integers.IntMethod(firstNum));
            }


            Console.ReadLine();
        }
    }
}
