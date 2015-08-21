using System;
using System.Globalization;
using System.Threading;

namespace Problem1.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            // Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
            // As a result print the values a and b, separated by a space.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please enter two numbers.\n");

            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                double temp = a + b;
                a = b;
                b = temp - a;
            }

            Console.WriteLine();
            Console.WriteLine("The numbers after exchanging their values are: {0} {1}",a,b);
        }
    }
}
