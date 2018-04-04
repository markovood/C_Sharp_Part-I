using System;

namespace SoftUni_Programming_Basics_Online_Exam_10and11_March2018
{
    public class PC_Store
    {
        public static void Main()
        {
            double priceCPUInUSD = double.Parse(Console.ReadLine());
            double priceVideoCardInUSD = double.Parse(Console.ReadLine());
            double priceRAMChipInUSD = double.Parse(Console.ReadLine());
            int numbOfRAMChips = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double totalMoneyNeeded = 0;
            totalMoneyNeeded += ConvertIntoBGN(priceCPUInUSD, discount);
            totalMoneyNeeded += ConvertIntoBGN(priceVideoCardInUSD, discount);
            totalMoneyNeeded += ConvertIntoBGN(priceRAMChipInUSD * numbOfRAMChips);

            Console.WriteLine("Money needed - {0:F2} leva.", totalMoneyNeeded);
        }

        private static double ConvertIntoBGN(double priceInUSD, double discount = 0)
        {
            const double BGNforUSD = 1.57;

            double priceInBGN = priceInUSD * BGNforUSD;
            double afterDiscount = priceInBGN - (priceInBGN * discount);
            return afterDiscount;
        }
    }
}