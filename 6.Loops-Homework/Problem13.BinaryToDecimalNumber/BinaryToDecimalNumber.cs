using System;
using System.Globalization;
using System.Threading;

namespace Problem13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            // Using loops write a program that converts a binary integer number to its decimal form.
            // The input is entered as string. The output should be a variable of type long.
            // Do not use the built-in .NET functionality.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Binary to decimal converter";

            // Binary To Decimal Algorithm --> http://markovood.eu/images/BinaryToDecimalAlgorithm.png
            Console.Write("Enter a binary representation: ");
            string binaryRepr = Console.ReadLine();

            long decimalNumber = 0L;

            for (int i = 0; i < binaryRepr.Length; i++)
            {
                decimalNumber += long.Parse(binaryRepr[i].ToString()) * (long)(Math.Pow(2, ((binaryRepr.Length - 1) - i)));
            }

            Console.WriteLine("Decimal equivalent: {0}",decimalNumber);
        }
    }
}
