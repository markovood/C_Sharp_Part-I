using System;
using System.Globalization;
using System.Threading;

namespace Problem16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            // Using loops write a program that converts an integer number to its hexadecimal representation.
            // The input is entered as long. The output should be a variable of type string.
            // Do not use the built-in .NET functionality.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Decimal To Hexadecimal Converter";

            // Decimal To Hexadecimal Algorithm --> http://markovood.eu/images/DecimalToHexadecimalAlgorithm.png
            Console.Write("Enter a decimal number: ");
            long decimalNumber = long.Parse(Console.ReadLine());

            // Checks if number is always positive
            while (decimalNumber < 0)
            {
                Console.Write("Error!\nPlease enter new number: ");
                decimalNumber = long.Parse(Console.ReadLine());
            }

            string temp = "";

            long remain = decimalNumber / 16;
            long remainder = decimalNumber % 16;
            switch (remainder)
            {
                case 10:
                    temp += "A";
                    break;
                case 11:
                    temp += "B";
                    break;
                case 12:
                    temp += "C";
                    break;
                case 13:
                    temp += "D";
                    break;
                case 14:
                    temp += "E";
                    break;
                case 15:
                    temp += "F";
                    break;
                default:
                    temp += remainder.ToString();
                    break;
            }

            for (long i = remain; i > 0; i /= 16)
            {
                // от значение е редът в който се смята --> първо "remainder" и после "remain"
                remainder = remain % 16;
                remain /= 16;
                switch (remainder)
                {
                    case 10:
                        temp += "A";
                        break;
                    case 11:
                        temp += "B";
                        break;
                    case 12:
                        temp += "C";
                        break;
                    case 13:
                        temp += "D";
                        break;
                    case 14:
                        temp += "E";
                        break;
                    case 15:
                        temp += "F";
                        break;
                    default:
                        temp += remainder.ToString();
                        break;
                }
            }

            // Reverses the string
            string hex = "";

            int index = temp.Length - 1;

            for (int i = 0; i < temp.Length; i++)
            {
                hex += temp[index - i];
            }

            Console.WriteLine("Your number in hex is: {0}",hex);
        }
    }
}
