using System;
using System.Globalization;
using System.Threading;

namespace Problem5.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            // Write a program that finds the biggest of three numbers.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Find the biggest of three numbers");
            Console.WriteLine();

            Console.Write("Enter number 1: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            double third = double.Parse(Console.ReadLine());

            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("The biggest number is {0}", first);
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}",third);
                }
            }

            else
            {
                if (second > third)
                {
                    Console.WriteLine("The biggest number is {0}", second);
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}", third);
                }
            }
        }
    }
}
