using System;
using System.Threading;
using System.Globalization;

namespace Problem9.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            // Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
            // Note: You may need to use a for-loop.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            Console.Write("Please specify how many numbers you want to sum: ");
            int userInput = int.Parse(Console.ReadLine());

            double sum = 0;

            for (double i = 1; i <= userInput; i++)
            {
                Console.Write("Enter number {0}: ",i);
                double enteredValue = double.Parse(Console.ReadLine());
                sum = sum + enteredValue;
            }

            string separator = new string('*', 55);

            Console.WriteLine(separator);
            Console.WriteLine("The sum is: {0}",sum);
            Console.WriteLine();
        }
    }
}
