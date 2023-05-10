using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //Setting the Ids to numbers to compare
            Employee employee1 = new Employee() { Id = 1 };
            Employee employee2 = new Employee() { Id = 2 };

            //Printing the bool comparisons to the console
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();


        }
    }
}
