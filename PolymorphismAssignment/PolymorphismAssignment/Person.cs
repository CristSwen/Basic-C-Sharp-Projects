using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public abstract class Person
    {
        //Creating two properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Creating a virtual method that will print the names.
        public virtual void SayName()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.ReadLine();
        }
        
    }
}
