using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //Can plus Employee into the parameter so you can set the Id, fName, and lName
            List<Employee> employeeList = new List<Employee> {
            new Employee { Id = 1, firstName = "Joe", lastName = "Johnson" },
            new Employee { Id = 2, firstName = "Jessica", lastName = "Prebble" },
            new Employee { Id = 3, firstName = "Holden", lastName = "Wilson" },
            new Employee { Id = 4, firstName = "Joe", lastName = "Habersburger" }
            };

            //The foreach loop for finding all the lovely Joes
            List<Employee> forEmpLoop = new List<Employee>();
            foreach (Employee i in employeeList)
            {
                if (i.firstName == "Joe")
                {
                    forEmpLoop.Add(i);
                }
            }
            foreach (Employee i in forEmpLoop)
            {
                Console.WriteLine(i.firstName + " " + i.lastName);
            }
            Console.ReadLine();
            
        }
    }
}
