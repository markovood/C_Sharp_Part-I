using System;
using System.Globalization;
using System.Threading;

namespace Problem11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            // Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min ... max].

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter the length of the sequence: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the minimum number between which the generated number will be: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum number between which the generated number will be: ");
            int max = int.Parse(Console.ReadLine());

            // Checks the rule --> min != max
            while ((min == max) || (min > max))
            {
                Console.Write("Minimal value should be less than maximal value!\nRe-enter minimal value: ");
                min = int.Parse(Console.ReadLine());
            }

            // new instance of the build-in in .NET random number generator class
            Random randomNumberGenerator = new Random();

            // Cleans the console window
            Console.Clear();

            Console.WriteLine("Here are {0} numbers between [{1}...{2}]", n, min, max);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", randomNumberGenerator.Next(min, max + 1)); // (max + 1) включва и стойността на "max" в случайно генерираните числа!
                // За по-интересен анимиран ефект
                Thread.Sleep(150);
            }

            // This is to put the "Press any key to continue..." away from the printout
            Console.WriteLine("\n");
        }
    }
}
