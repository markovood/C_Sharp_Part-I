using System;
using System.Globalization;
using System.Threading;

namespace Problem1.ABC
{
    class ABC
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int biggest = 0;
            int smallest = 0;
            decimal arithmeticMean = 0;

            // find biggest
            if (A > B)
            {
                if (A > C)
                {
                    biggest = A;
                }
                else
                {
                    biggest = C;
                }
            }
            else
            {
                if (B > C)
                {
                    biggest = B;
                }
                else
                {
                    biggest = C;
                }
            }

            // find smallest
            if (A < B)
            {
                if (A < C)
                {
                    smallest = A;
                }
                else
                {
                    smallest = C;
                }
            }
            else
            {
                if (B < C)
                {
                    smallest = B;
                }
                else
                {
                    smallest = C;
                }
            }


            arithmeticMean = (A + B + C) / 3m;  // "3m" is "3.00m" i.e. decimal type of the integer 3

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:F3}", arithmeticMean);
        }
    }
}
