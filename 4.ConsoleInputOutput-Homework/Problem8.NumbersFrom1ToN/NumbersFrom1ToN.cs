using System;
using System.Threading;
using System.Globalization;

namespace Problem8.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Title = "problem 8".ToUpper();
            // Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter the number up to which you want to see the whole interval: ");
            int userInput = int.Parse(Console.ReadLine());

            for (int interval = 1; interval <= userInput; interval++)
            {
                Console.WriteLine(interval);
            }
        }
    }
}
