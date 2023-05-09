using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public static class StaticClass
    {
        //A static method that will print the name to the console.
        public static void staticMethod(string name)
        {

            Console.WriteLine("Hello {0}, how are you!", name);
            Console.ReadLine();
        }

        
    }
}
