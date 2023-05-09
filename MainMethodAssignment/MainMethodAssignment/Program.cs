using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            //Console.WriteLine("Please enter a integer");
            //int intResult = Convert.ToInt32(Console.ReadLine());
            //int firstResult = numbers.myFunc(intResult);
            //Console.WriteLine(firstResult);
            //Console.ReadLine();

            Console.WriteLine("Please enter a decimal");
            decimal floResult = Convert.ToDecimal(Console.ReadLine());
            int secondResult = numbers.myFunc(floResult);
            Console.WriteLine(secondResult);
            Console.ReadLine();

            //Console.WriteLine("Please enter a number");
            //string strResult = Console.ReadLine();
            //int lastResult = numbers.myFunc(strResult);
            //Console.WriteLine(lastResult);
            //Console.ReadLine();
        }
    }
}
