using System;
using System.Globalization;
using System.Threading;

namespace Problem1.Garden
{
    class Garden
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int tomatoSeeds = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberSeeds = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoSeeds = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carotSeeds = int.Parse(Console.ReadLine());
            int carotArea = int.Parse(Console.ReadLine());
            int cabbageSeeds = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beansSeeds = int.Parse(Console.ReadLine());

            int totalArea = 250;
            decimal tomatoSeedsPrice = 0.5m;
            decimal cucumberSeedsPrice = 0.4m;
            decimal potatoSeedsPrice = 0.25m;
            decimal carotSeedsPrice = 0.6m;
            decimal cabbageSeedsPrice = 0.3m;
            decimal beansSeedsPrice = 0.4m;

            decimal totalPrice = 0;
            int areaLeft = 0;
            int totalAreaUsed = tomatoArea + cucumberArea + potatoArea + carotArea + cabbageArea;

            totalPrice = tomatoSeeds * tomatoSeedsPrice + cucumberSeeds * cucumberSeedsPrice + potatoSeeds * potatoSeedsPrice + carotSeeds * carotSeedsPrice + cabbageSeeds * cabbageSeedsPrice + beansSeeds * beansSeedsPrice;
            areaLeft = totalArea - totalAreaUsed;

            Console.WriteLine("Total costs: {0:0.00}", totalPrice);
            if (areaLeft > 0)
            {
                Console.WriteLine("Beans area: {0}", areaLeft);
            }
            else if (areaLeft == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else if (areaLeft < 0)
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
