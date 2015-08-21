using System;
using System.Globalization;
using System.Threading;

namespace Problem14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            // Using loops write a program that converts an integer number to its binary representation.
            // The input is entered as long. The output should be a variable of type string.
            // Do not use the built-in .NET functionality.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Decimal to Binary converter";

            // Decimal To Binary Algorithm --> http://markovood.eu/images/DecimalToBinaryAlgorithm.png
            Console.Write("Enter decimal number: ");
            long decimalNumber = long.Parse(Console.ReadLine());
            
            // Checks if number is always positive
            while (decimalNumber < 0)
            {
                Console.Write("Error!\nPlease enter new number: ");
                decimalNumber = long.Parse(Console.ReadLine());
            }

            long remain = decimalNumber / 2;
            long remainder = decimalNumber % 2;
            string temp = remainder.ToString();

            for (long i = remain; i > 0; i /= 2)
            {
                remainder = remain % 2;
                remain /= 2;
                temp += remainder.ToString();
            }


            // String in reverse order algorithm
            string binaryRepr = "";

            int index = temp.Length - 1;

            for (int i = 0; i < temp.Length; i++)
            {
                binaryRepr += temp[index - i];
            }

            Console.WriteLine("Binary representation is: {0}",binaryRepr);
        }
    }
}
