using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE OF CONSOLE APP ASSIGNMENT **********

            //Creates an array and asks the user for a random input word
            //string[] strArray = { "text", "what" };
            //Console.WriteLine("Enter in some text");
            //string response = Console.ReadLine();

            ////iterating over the indices of the array using a forloop and adding them to the string. a foreach loop does not work for this loop
            //for (int i = 0; i < strArray.Length; i++)

            //{

            //    strArray[i] = strArray[i] + response;
            //}

            //foreach (string i in strArray)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadLine();
            //}



            // PART TWO OF CONSOLE APP ASSIGNMENT ************

            //This is the infinite loop
            //int num = 5;
            //while (num < 6)
            //{
            //    Console.WriteLine("Oh no, it won't stop");

            //}
            //Console.ReadLine();

            //This is the infinite loop fixed to not be infinite

            //for (int num = 5; num < 8; num++)
            //{
            //    Console.WriteLine(num);
            //    Console.ReadLine();
            //}


            // PART THREE OF THE CONSOLE APP ASSIGNMENT *********
            // for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //for (int i = 0; i <= 6; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();



            // PART FOUR OF THE CONSOLE APP ASSIGNMENT ***********
            //List<string> strList = new List<string>();
            //strList.Add("strawberry");
            //strList.Add("onion");
            //strList.Add("blueberry");
            //strList.Add("seaweed");

            //Console.WriteLine("User! Search for a Fruit or Veggie! ex.'apple'");
            //string response = Console.ReadLine();

            ////This for loop chekcs if response is equal to i
            //for (int i = 0; i < strList.Count; i++)
            //{
            //    if (strList[i] == response)
            //    {
            //        //if the reponse is equal to i, it will print the index and name
            //        Console.WriteLine("{0}: {1}", response, i);
            //        Console.ReadLine();
            //        break;
            //    }
            //    else
            //    {
            //        //This will print not there for every item in the list then end the code.
            //        Console.WriteLine("Not there");
            //        Console.ReadLine();

            //    }
            //}



            // PART FIVE OF THE CONSOLE APP ASSIGNMENT ****
            List<string> strList = new List<string>();
            strList.Add("loco");
            strList.Add("loco");
            strList.Add("itzy");
            Console.WriteLine("Enter a word to search for");
            string response = Console.ReadLine();
            bool match = false;
            for (int i = 0; i < strList.Count; i++)
            {
                if (strList[i] == response)
                {
                    Console.WriteLine("Found {0} at {1}", response, i);
                    Console.ReadLine();
                    match = true;
                }
            }
            if (!match)
            {
                Console.WriteLine("Could not find what you searched for");
                Console.ReadLine();
            }
        }
    }
}
