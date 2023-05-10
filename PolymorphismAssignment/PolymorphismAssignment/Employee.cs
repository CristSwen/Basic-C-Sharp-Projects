using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Employee : Person, IQuittable
    {
        //Inheriting the Person class.
        //Because Person class is Abstract, we must override it to use it
        public override void SayName()
        {
            Console.WriteLine("Employee:");
            base.SayName();
        }
        
        //Calling the Quit method to print something to the console
        public void Quit()
        {
            Console.WriteLine("{0} is a person", firstName);
        }
        
        
    }
}
