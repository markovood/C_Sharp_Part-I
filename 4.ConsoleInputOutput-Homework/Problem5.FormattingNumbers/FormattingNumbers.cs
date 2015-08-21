using System;
using System.Threading;
using System.Globalization;

namespace Problem5.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            // Write a program that reads 3 numbers:
            // 
            // integer a (0 <= a <= 500)
            // floating-point b
            // floating-point c
            // 
            // The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            // 
            // The number a should be printed in hexadecimal, left aligned
            // Then the number a should be printed in binary form, padded with zeroes
            // The number b should be printed with 2 digits after the decimal point, right aligned
            // The number c should be printed with 3 digits after the decimal point, left aligned.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number greater than or equal to 0 and less than or equal to 500: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter floating-point number: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Enter floating-point number: ");
            float c = float.Parse(Console.ReadLine());

            string separator = new string('-', 45);
            Console.WriteLine();
            Console.WriteLine("|{0,10}|{0,10}|{1,10}|{2,10}|", a, b, c);
            Console.WriteLine(separator);
            Console.Write("|{0,-10:X}|", a);
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0') + "|");
            Console.Write("{0,10:F2}|", b);
            Console.Write("{0,-10:F3}|", c);
            Console.WriteLine("\n" + separator);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
