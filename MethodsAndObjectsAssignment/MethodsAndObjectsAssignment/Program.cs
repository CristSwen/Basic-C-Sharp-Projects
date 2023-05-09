using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing the employee object with a first/last name
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Calling the superlative class
            employee.SayName();
        }
    }
}
