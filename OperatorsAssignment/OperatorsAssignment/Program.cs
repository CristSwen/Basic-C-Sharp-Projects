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
            int id1 = employee.Id = 12;
            int id2 = employee.Id = 12;

            bool equal = id1 == id2;
            bool notEqual = id1 != id2;

            Console.WriteLine(equal);
            Console.WriteLine(notEqual);
            Console.ReadLine();
        }
    }
}
