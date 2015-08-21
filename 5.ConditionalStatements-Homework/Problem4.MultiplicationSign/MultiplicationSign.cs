using System;
using System.Globalization;
using System.Threading;

namespace Problem4.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            // Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            // Use a sequence of if operators.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter 3 real numbers to check the sign (+, - or 0) of their product without calculating it.");
            Console.WriteLine();

            Console.Write("Enter first: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter second: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter third: ");
            double third = double.Parse(Console.ReadLine());

            if (first < 0 && second < 0 && third < 0)
            {
                Console.WriteLine("The product will be -");
            }

            else if (first > 0 && second > 0 && third < 0)
            {
                Console.WriteLine("The product will be -");
            }

            else if (first < 0 && second > 0 && third > 0)
            {
                Console.WriteLine("The product will be -");
            }

            else if (first > 0 && second < 0 && third > 0)
            {
                Console.WriteLine("The product will be -");
            }

            else if (first == 0)
            {
                Console.WriteLine("The product will be 0");
            }

            else if (second == 0)
            {
                Console.WriteLine("The product will be 0");
            }

            else if (third == 0)
            {
                Console.WriteLine("The product will be 0");
            }

            else if (first > 0 && second > 0 && third > 0)
            {
                Console.WriteLine("The product will be +");
            }

            else if (first > 0 && second < 0 && third < 0)
            {
                Console.WriteLine("The product will be +");
            }

            else if (first < 0 && second > 0 && third < 0)
            {
                Console.WriteLine("The product will be +");
            }

            else if (first < 0 && second < 0 && third > 0)
            {
                Console.WriteLine("The product will be +");
            }

            else
            {
                Console.WriteLine("Ops, something went wrong...");
            }
        }
    }
}
