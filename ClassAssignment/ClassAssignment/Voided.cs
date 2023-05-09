using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Voided
    {
        //A method that will return the user inputted number divided by 2
        public void IntMethod(int num)
        {
            int operation = num / 2;
            Console.WriteLine(operation);
            Console.ReadLine();
        }

        //This is a method with out paramters that will return multiple values.
        public void OutMethod(out int number, out string response)
        {
            number = 23;
            response = "You shall not pass";
        }

        //Overloaded version of IntMethod
        public void IntMethod(decimal num)
        {
            decimal operation = num + 52;
            Console.WriteLine(operation);
            Console.ReadLine();
        }
    }
}
