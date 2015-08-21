using System;
using System.Globalization;
using System.Threading;

namespace Problem1.CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            decimal N1 = decimal.Parse(Console.ReadLine()) * 0.05m;
            decimal N2 = decimal.Parse(Console.ReadLine()) * 0.1m;
            decimal N3 = decimal.Parse(Console.ReadLine()) * 0.2m;
            decimal N4 = decimal.Parse(Console.ReadLine()) * 0.5m;
            decimal N5 = decimal.Parse(Console.ReadLine()) * 1.0m;
            decimal A = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            decimal sumInTrays = N1 + N2 + N3 + N4 + N5;
            decimal change = A - P;

            if ((A >= P) && (sumInTrays >= change))
            {
                Console.WriteLine("Yes {0}", sumInTrays - change);
            }
            else if (P > A)
            {
                Console.WriteLine("More {0}", P - A);
            }
            else
            {
                Console.WriteLine("No {0}", change - sumInTrays);
            }
        }
    }
}
