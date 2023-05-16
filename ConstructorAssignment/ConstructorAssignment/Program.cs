using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Wowza";
            var varName = "variable";

            string together = name + varName;
            Console.WriteLine(together);
            Console.ReadLine();
        }
    }
}
