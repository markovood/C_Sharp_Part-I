using System;
using System.Threading;
using System.Globalization;

namespace Problem7.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter five numbers separated by space: ");
            string userInput = Console.ReadLine();

            string[] numbers = userInput.Split(' ');

            double firstNum = double.Parse(numbers[0]);
            double secondNum = double.Parse(numbers[1]);
            double thirdNum = double.Parse(numbers[2]);
            double fourthNum = double.Parse(numbers[3]);
            double fifthNum = double.Parse(numbers[4]);

            string separator = new string('*', 55);

            Console.WriteLine(separator);
            Console.WriteLine("The sum of all numbers is: " + (firstNum + secondNum + thirdNum + fourthNum + fifthNum));
            Console.WriteLine();
        }
    }
}
