using System;
using System.Globalization;
using System.Threading;

namespace Problem2.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers
            // from 1 to n not divisible by 3 or 7, on a single line, separated by a space.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter a positive number here: ");
            int n = int.Parse(Console.ReadLine());

            // Makes sure that the entered number will always be positive
            while (n < 0)
            {
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }

            // This is to place the "Press any key to continue..." away from the output
            Console.WriteLine("\n");
        }
    }
}
