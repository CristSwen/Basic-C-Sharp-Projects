using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>();
                intList.Add(12);
                intList.Add(22);
                intList.Add(3);

                Console.WriteLine("User! Please type a number to divide each number in a list by");
                int divNumber = Convert.ToInt32(Console.ReadLine());

                //This loop will iterate through all the numbers in the list and divide them by the number the user inputs
                foreach (int num in intList)
                {
                    int finalNum = num / divNumber;
                    Console.WriteLine(finalNum);
                }
                
            }
            //This will see if the exception is a format exception
            catch (FormatException ex)
            {
                Console.WriteLine("You didn't enter a whole number!");
            }
            //This will check if the exception is someone tryna divide by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
