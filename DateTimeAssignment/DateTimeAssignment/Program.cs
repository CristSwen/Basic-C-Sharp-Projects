using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Yo. Type a number");
            int answer = int.Parse(Console.ReadLine());

            DateTime theTime = DateTime.Now.AddHours(answer);
            Console.WriteLine("Did you know in {0} hours, it will be {1}? Yeah neither did I.", answer, theTime);
            Console.ReadLine();
            
            
        }
    }
}
