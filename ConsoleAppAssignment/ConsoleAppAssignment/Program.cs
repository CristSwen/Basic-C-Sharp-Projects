﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Please guess what month it is. Ex. '03' ");
            ////int month = Convert.ToInt32(Console.ReadLine());
            //////The bool is taking the month variable and making 12 true
            ////bool isGuessed = month == 12;

            //////The Do statement will check if any of the cases have been met.
            ////do
            ////{
            ////    switch (month)
            ////    {
            ////        case 01:
            ////            Console.WriteLine("It's not January silly");
            ////            Console.WriteLine("Guess another month");
            ////            month = Convert.ToInt32(Console.ReadLine());
            ////            break;

            ////        case 04:
            ////            Console.WriteLine("It's not April silly");
            ////            Console.WriteLine("Guess another month");
            ////            month = Convert.ToInt32(Console.ReadLine());
            ////            break;

            ////        case 12:
            ////            Console.WriteLine("It's not December silly");
            ////            Console.WriteLine("Guess another month");
            ////            month = Convert.ToInt32(Console.ReadLine());
            ////            break;

            ////        //The correct month if guessed.
            ////        case 05:
            ////            Console.WriteLine("You finally guessed May. Was about time!");
            ////            isGuessed = true;
            ////            break;

            ////        //If none of the other months are guessed, default to this
            ////        default:
            ////            Console.WriteLine("Guessed the wrong month!");
            ////            Console.WriteLine("Guess another month!");
            ////            month = Convert.ToInt32(Console.ReadLine());
            ////            break;
            ////    }
            ////}
            ////while (!isGuessed);

            ////Console.Read();

            Console.WriteLine("Try to guess my favorite number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numGuessed = number == 21;

            while (!numGuessed)
            {
                switch (number)
                {
                    case 3:
                        Console.WriteLine("Yikes! Not 3! Try again!");
                        Console.WriteLine("Guess another one");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 50:
                        Console.WriteLine("A little too high! Try again");
                        Console.WriteLine("Guess another one");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 21:
                        Console.WriteLine("You Guessed it! 21 is the best, because of the meme!");
                        numGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Wrong number! Try again!");
                        Console.WriteLine("Guess another one!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}
