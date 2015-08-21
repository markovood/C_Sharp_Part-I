using System;
using System.Globalization;
using System.Threading;

namespace Problem1.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter a positive number here: ");
            int n = int.Parse(Console.ReadLine());

            // Makes sure that the entered number will always be positive 
            while (n < 0)
            {
                Console.Write("Please enter a non-negative number: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }

            // This is to place the "Press any key to continue..." away from the output
            Console.WriteLine("\n");
        }
    }
}
