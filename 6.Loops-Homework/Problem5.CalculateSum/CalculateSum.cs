using System;
using System.Globalization;
using System.Threading;

namespace Problem5.CalculateSum
{
    class CalculateSum
    {
        static void Main()
        {
            // Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x^1 + 2!/x^2 + ... + n!/x^n.
            // Use only one loop. Print the result with 5 digits after the decimal point.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // Тук въвеждаме стойности за "n" и "x"
            int n = 5;
            int x = -4;

            // По подразбиране задаваме стойност на факториела 1 тъй като ще умножаваме, а всичко умножено по 1 е същото число
            int factorial = 1;

            // По подразбиране първоначалната сума ще е 1 и към нея ще прибавяме факториела делен на "x" на степен от 1 до "n"
            double sum = 1.0;

            // При всяко завъртане ще се смята факториел като всъщност ще се умножава вече получения по поредното число 
            // (Така си гарантираме,че винаги ще се смята факториел до "n!")
            // и след разделяне на "x" на степен от 1 до "n" ще се натрупва в "sum"
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += (factorial / Math.Pow(x, i));
            }

            Console.WriteLine("{0:0.00000}",sum);
        }
    }
}
