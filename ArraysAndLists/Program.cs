using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            int[] array = new int[10];
            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 1; i <= array.Length; i++)
            {
                if (i % 2 == 0)
                {

                    evens.Add(i);


                }
                else
                {
                    odds.Add(i);

                }
            }


            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Bellow are the even numbers:");

            foreach (var item in evens)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Bellow are the odd numbers:");

            foreach (var num in odds)
            {
                Console.Write(num + " ");
            }
        }
    }
}
