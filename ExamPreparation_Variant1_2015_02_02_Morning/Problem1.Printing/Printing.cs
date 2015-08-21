using System;
using System.Globalization;
using System.Threading;

namespace Problem1.Printing
{
    class Printing
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int numberOfStudents = int.Parse(Console.ReadLine());
            decimal numberSheetsPerPerson = decimal.Parse(Console.ReadLine());
            decimal priceOfRealm = decimal.Parse(Console.ReadLine());

            decimal savedAmount = 0m;

            int oneRealm = 500;
            decimal totalNumberOfSheets = numberOfStudents * numberSheetsPerPerson;
            decimal totalRealms = totalNumberOfSheets / 500;
            savedAmount = priceOfRealm * totalRealms;

            Console.WriteLine("{0:F2}",savedAmount);
        }
    }
}
