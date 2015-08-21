using System;
using System.Globalization;
using System.Threading;

namespace Problem18.TrailingZeroesInNFactorial
{
    class TrailingZeroesInNFactorial
    {
        static void Main()
        {
            // Write a program that calculates with how many zeros the factorial of a given number n has at its end.
            // Your program should work well for very big numbers, e.g. n=100000.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Trailing Zeros in N!";

            // For more detailed explanation --> http://www.purplemath.com/modules/factzero.htm

            Console.Write("Enter a positive number to check how many zeros its factorial has: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            while (n < 0)
            {
                Console.Write("NON-NEGATIVE NUMBER PLS!!! ");
                n = int.Parse(Console.ReadLine());
            }

            // Take the number that you've been given the factorial of.
            // Divide by 5^1 = 5; if you get a decimal, truncate to a whole number.
            // Divide by 5^2 = 25; if you get a decimal, truncate to a whole number.
            // Divide by 5^3 = 125; if you get a decimal, truncate to a whole number.
            // Continue with ever-higher powers of 5, until your division results in a number less than 1. Once the division is less than 1, stop.
            // Sum all the whole numbers you got in your divisions. This is the number of trailing zeros.

            for (int i = 1; Math.Pow(5, i) < n; i++)
            {
                count += (n / (int)(Math.Pow(5, i)));
            }

            Console.Clear();
            Console.WriteLine("{0}! has {1} trailing zeros",n,count);
        }
    }
}
