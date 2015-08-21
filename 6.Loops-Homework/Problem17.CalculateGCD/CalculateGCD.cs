using System;
using System.Globalization;
using System.Threading;

namespace Problem17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            // Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
            // Use the Euclidean algorithm (find it in Internet).

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // Алгоритъмът на Евклид: 
            //1) За делимо се взима по-голямото число, а за делител - по-малкото число. 
            //2) Делителя от предишната стъпка се разделя на получения остатък. 
            //3) Това се повтаря дотогава, докато получим остатък 0. 
            //Този делител, при който частното няма остатък е НОД. 

            Console.Write("Give value for a: ");
            int dividend = int.Parse(Console.ReadLine());

            Console.Write("Give value for b: ");
            int divisor = int.Parse(Console.ReadLine());

            // EXCHANGES IF "dividend" IS LESS THAN "divisor"
            if (dividend < divisor)
            {
                int temp = dividend + divisor;
                dividend = divisor;
                divisor = temp - dividend;
            }

            int remainder = dividend % divisor;

            while (divisor % remainder != 0)
            {
                dividend = divisor;
                divisor = remainder;
                remainder = dividend % divisor;
            }

            Console.WriteLine(new string('-',25));
            Console.WriteLine("GCD(a,b) = {0}",remainder);
        }
    }
}
