using System;

namespace SpecialCombinations
{
    public class SpecialCombinations
    {
        public static void Main()
        {
            int hundreds = int.Parse(Console.ReadLine());
            int decimals = int.Parse(Console.ReadLine());
            int singles = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundreds; i++)
            {
                for (int j = 1; j <= decimals; j++)
                {
                    for (int k = 1; k <= singles; k++)
                    {
                        if (i % 2 == 0 &&
                            k % 2 == 0 &&
                            IsPrime(j))
                        {
                            Console.WriteLine("{0} {1} {2}", i, j, k);
                        }
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
