using System;
using System.Globalization;
using System.Threading;

namespace Problem6.TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            // Write a program that finds the biggest of five numbers by using only five if statements.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter 5 numbers to find which is the biggest of them");
            Console.WriteLine();



            Console.Write("Enter first: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter second: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter third: ");
            double third = double.Parse(Console.ReadLine());

            Console.Write("Enter fourth: ");
            double fourth = double.Parse(Console.ReadLine());

            Console.Write("Enter fifth: ");
            double fifth = double.Parse(Console.ReadLine());



            if (Math.Max(first, second) > Math.Max(third, fourth))
            {
                if (Math.Max(first, second) > fifth)
                {
                    Console.WriteLine("The biggest number is {0}", Math.Max(first, second));
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}", fifth);
                }
            }
            else
            {
                if (Math.Max(third, fourth) > fifth)
                {
                    Console.WriteLine("The biggest number is {0}", Math.Max(third, fourth));
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}", fifth);
                }
            }
        }
    }
}
