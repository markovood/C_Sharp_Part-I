using System;
using System.Threading;
using System.Globalization;

namespace Problem1.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            // Write a program that reads 3 real numbers from the console and prints their sum.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter a real number: ");
            double userInput1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter second real number: ");
            double userInput2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter third real number: ");
            double userInput3 = double.Parse(Console.ReadLine());

            double result = userInput1 + userInput2 + userInput3;

            Console.WriteLine("The sum of the entered numbers {0}, {1} and {2} is: {3}", userInput1, userInput2, userInput3, result);
        }
    }
}
