using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Voided voided = new Voided();

            //Asking the user for a number and printing the response to the screen from the void method
            //Console.WriteLine("Please enter a number");
            //int answer = Convert.ToInt32(Console.ReadLine());
            //voided.IntMethod(answer);


            //Printing the out method to the screen
            //int argNumber;
            //string argResponse;
            //voided.OutMethod(out argNumber, out argResponse);
            //Console.WriteLine(argNumber);
            //Console.WriteLine(argResponse);
            //Console.ReadLine();


            //Asking the user for a number and printing it to the screen using the overloaded method.
            Console.WriteLine("Please enter a decimal number to add");
            decimal answer = Convert.ToDecimal(Console.ReadLine());
            voided.IntMethod(answer);


            //A static method that will print the name to the console.
            //static void staticMethod(string name)
            //{
                
            //    Console.WriteLine("Hello {0}, how are you!", name);
            //}

            //Console.WriteLine("Tell me your name");
            //string response = Console.ReadLine();
            //staticMethod(response);
        }
    }
}
