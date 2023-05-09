using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Voided voided = new Voided();

            Console.WriteLine("Please enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());
            voided.IntMethod(answer);
        }
    }
}
