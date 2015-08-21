using System;
using System.Globalization;
using System.Threading;

namespace Problem2.AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            long N = long.Parse(Console.ReadLine());

            long sumOfEvenDigits = 0;
            long sumOfOddDigits = 0;
            long currentNumber = 0;

            if (N < 0)
            {
                N *= -1;
            }

            for (long i = N; i != 0; i /= 10)
            {
                currentNumber = i % 10;
                if (currentNumber % 2 == 0)
                {
                    sumOfEvenDigits += currentNumber;
                }
                else
                {
                    sumOfOddDigits += currentNumber;
                }
            }

            if (sumOfEvenDigits > sumOfOddDigits)
            {
                Console.WriteLine("right {0}", sumOfEvenDigits);
            }
            else if (sumOfOddDigits > sumOfEvenDigits)
            {
                Console.WriteLine("left {0}", sumOfOddDigits);
            }
            else
            {
                Console.WriteLine("straight {0}", sumOfEvenDigits);
            }
        }
    }
}
