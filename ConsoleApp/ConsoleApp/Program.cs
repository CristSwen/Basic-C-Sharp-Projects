using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "text", "what" };
            Console.WriteLine("Enter in some text");
            string response = Console.ReadLine();

            //iterating over the indices of the array using a forloop
            for (int i = 0; i < strArray.Length; i++)
                
            {

                strArray[i] = strArray[i] + response;
            }

            foreach (string i in strArray)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

        }
    }
}
