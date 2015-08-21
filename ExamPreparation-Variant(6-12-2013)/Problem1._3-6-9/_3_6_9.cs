using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem1._3_6_9
{
    class _3_6_9
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());

            long R = 0;

            if (B == 3)
            {
                R = A + C;
            }
            else if (B == 6)
            {
                R = A * C;
            }
            else if (B == 9)
            {
                R = A % C;
            }

            if (R % 3 == 0)
            {
                Console.WriteLine(R/3);
                Console.WriteLine(R);
            }
            else
            {
                Console.WriteLine(R%3);
                Console.WriteLine(R);
            }


        }
    }
}
