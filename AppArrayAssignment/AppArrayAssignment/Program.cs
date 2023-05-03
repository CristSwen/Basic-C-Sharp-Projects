using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Created a str array and the console will print which index the user chose
            //string[] strArray = { "Elspeth", "Zendikar", "Inga", "Yarok"};
            //Console.WriteLine("User! Type an index between 0 and 3");
            //int response = Convert.ToInt32(Console.ReadLine());
            //if (response > 3)
            //{
            //    Console.WriteLine("That's not a valid index");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine(strArray[response]);
            //    Console.ReadLine();
            //}


            ////Created a int array and the console will print which index the user chose
            //int[] intArray = { 1, 3, 5, 7, 9 };
            //Console.WriteLine("User! Type an index between 0 and 4");
            //int response1 = Convert.ToInt32(Console.ReadLine());
            //if (response1 > 4)
            //{
            //    Console.WriteLine("That's not a valid index");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine(intArray[response1]);
            //    Console.ReadLine();
            //}


            //Created a list of strings that a user can type an index and it will print the index
            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            Console.WriteLine("User! Type an index between 0 and 3");
            int select = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[select]);
            Console.ReadLine();
        }
    }
}
