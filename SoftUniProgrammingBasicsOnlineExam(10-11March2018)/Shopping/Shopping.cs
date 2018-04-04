using System;

namespace Shopping
{
    public class Shopping
    {
        public static void Main()
        {
            const double PRICE_CHOKO = 0.65;
            const double PRICE_MILK = 2.7;
            const double PRICE_MANDARIN = 0.2;

            const string POSITIVE_RESULT = "You got this, {0:F2} money left!";
            const string NEGATIVE_RESULT = "Not enough money, you need {0:F2} more!";

            double budget = double.Parse(Console.ReadLine());
            int numbOfChoko = int.Parse(Console.ReadLine());
            double litersOfMilk = double.Parse(Console.ReadLine());

            double totalMoneyForChoko = numbOfChoko * PRICE_CHOKO;
            double totalMoneyForMilk = litersOfMilk * PRICE_MILK;
            double totalMoneyForMandarins = Math.Floor((numbOfChoko - (numbOfChoko * 0.35))) * PRICE_MANDARIN;
            double totalMoneyNeeded =
                totalMoneyForChoko +
                totalMoneyForMilk +
                totalMoneyForMandarins;

            if (budget >= totalMoneyNeeded)
            {
                Console.WriteLine(String.Format(POSITIVE_RESULT, budget - totalMoneyNeeded));
            }
            else
            {
                Console.WriteLine(String.Format(NEGATIVE_RESULT, totalMoneyNeeded - budget));
            }
        }
    }
}
