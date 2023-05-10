using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            

            //Creating a new first name to be called
            IQuittable quittableName = new Employee { firstName = "Richard" };
            quittableName.Quit();
            Console.ReadLine();
        }
    }
}
