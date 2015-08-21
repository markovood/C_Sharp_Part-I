using System;
using System.Globalization;
using System.Threading;

namespace Problem1.Money
{
    class Money
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int N = int.Parse(Console.ReadLine());
            double S = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double totalSheets = N * S;
            double totalRealm = totalSheets / 400;
            double savedAmount = totalRealm * P;


            Console.WriteLine("{0:F3}",savedAmount);

        }
    }
}
