using System;
using System.Globalization;
using System.Threading;

namespace Problem1.ThreeNumbers
{
    class ThreeNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int biggest = 0;
            int smallest = 0;
            decimal arithmeticMean = 0m;

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

            arithmeticMean = (A + B + C) / (decimal)3;

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:F2}", arithmeticMean);
        }
    }
}
