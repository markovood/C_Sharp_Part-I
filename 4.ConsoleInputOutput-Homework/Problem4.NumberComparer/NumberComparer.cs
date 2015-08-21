using System;
using System.Threading;
using System.Globalization;

namespace Problem4.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            // Write a program that gets two numbers from the console and prints the greater of them.
            // Try to implement this without if statements.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Number comparer";

            Console.Write("Enter number to compare: ");
            double userNumber1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number to compare: ");
            double userNumber2 = double.Parse(Console.ReadLine());

            double compareResult = userNumber1 > userNumber2 ? userNumber1 : userNumber2;
            Console.WriteLine();
            Console.WriteLine("The greater number is: {0} ",compareResult);

        }
    }
}
