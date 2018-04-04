using System;

namespace PrimePairs
{
    public class PrimePairs
    {
        public static void Main()
        {
            int firstPair = int.Parse(Console.ReadLine());
            int secondPair = int.Parse(Console.ReadLine());
            int firstPairDifference = int.Parse(Console.ReadLine());
            int secondPairDifference = int.Parse(Console.ReadLine());

            for (int i = firstPair; i <= firstPair + firstPairDifference; i++)
            {
                for (int j = secondPair; j <= secondPair + secondPairDifference; j++)
                {
                    if (IsPrime(i) && 
                        IsPrime(j))
                    {
                        Console.WriteLine("{0}{1}", i, j); 
                    }
                }
            }
        }

        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
