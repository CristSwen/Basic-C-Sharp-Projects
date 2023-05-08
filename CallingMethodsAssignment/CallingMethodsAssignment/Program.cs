using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This instantiates the Integer class
            Integer integer = new Integer();

            Console.WriteLine("Please enter a whole number");
            int responseOne = Convert.ToInt32(Console.ReadLine());

            //for multiply
            int multResult = integer.Multiply(responseOne);
            Console.WriteLine(multResult);
            Console.ReadLine();

            //For Addition
            int addResult = integer.Addition(responseOne);
            Console.WriteLine(addResult);
            Console.ReadLine();

            //For Subtraction
            int subResult = integer.Subtraction(responseOne);
            Console.WriteLine(subResult);
            Console.ReadLine();



        }
    }
}
