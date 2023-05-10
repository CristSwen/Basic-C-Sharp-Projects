using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person
    {
        //Inheriting the Person class.
        //Because Person class is Abstract, we must override it to use it
        public override void SayName()
        {
            Console.WriteLine("Employee:");
            base.SayName();
        }
    }
}
