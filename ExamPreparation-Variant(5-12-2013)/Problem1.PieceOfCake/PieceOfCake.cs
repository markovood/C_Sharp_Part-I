using System;
using System.Globalization;
using System.Threading;

namespace Test
{
    class Test
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());
            decimal D = decimal.Parse(Console.ReadLine());

            decimal sum = (A / B) + (C / D);

            if (sum >= 1)
            {
                Console.WriteLine((int)sum);
            }
            else
            {
                Console.WriteLine("{0:F22}", sum);
            }


            decimal sumAsFraction = sum * (B * D);

            Console.WriteLine("{0}/{1}", Math.Round(sumAsFraction), B * D);
        }
    }
}
