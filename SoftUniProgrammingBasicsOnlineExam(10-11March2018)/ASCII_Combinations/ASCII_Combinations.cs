using System;
using System.Collections.Generic;

namespace ASCII_Combinations
{
    public class ASCII_Combinations
    {
        public static void Main()
        {
            int numbOfSymbols = int.Parse(Console.ReadLine());

            List<char> digits = new List<char>();
            List<char> capitals = new List<char>();
            List<char> smalls = new List<char>();
            List<char> others = new List<char>();

            for (int i = 0; i < numbOfSymbols; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                if (char.IsDigit(currentChar))
                {
                    digits.Add(currentChar);
                }
                else if (char.IsUpper(currentChar))
                {
                    capitals.Add(currentChar);
                }
                else if (char.IsLower(currentChar))
                {
                    smalls.Add(currentChar);
                }
                else
                {
                    others.Add(currentChar);
                }
            }

            List<int> sums = new List<int>();

            int digitsTotalSum = Sum(digits);
            sums.Add(digitsTotalSum);

            int capitalsTotalSum = Sum(capitals);
            sums.Add(capitalsTotalSum);

            int smallsTotalSum = Sum(smalls);
            sums.Add(smallsTotalSum);

            int othersTotalSum = Sum(others);
            sums.Add(othersTotalSum);

            int biggestSumIndex = FindBiggestSumIndex(sums);
            string biggestSumChars = string.Empty;
            switch (biggestSumIndex)
            {
                case 0:
                    biggestSumChars = string.Join("", digits);
                    break;
                case 1:
                    biggestSumChars = string.Join("", capitals);
                    break;
                case 2:
                    biggestSumChars = string.Join("", smalls);
                    break;
                case 3:
                    biggestSumChars = string.Join("", others);
                    break;
            }

            Console.WriteLine("Biggest ASCII sum is:{0}", sums[biggestSumIndex]);
            Console.WriteLine("Combination of characters is:{0}", biggestSumChars);
        }

        private static int FindBiggestSumIndex(List<int> sums)
        {
            int maxIndex = 0;
            for (int i = 1; i < sums.Count; i++)
            {
                if (sums[i] > sums[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            return maxIndex;
        }

        private static int Sum(List<char> list)
        {
            int sum = 0;
            foreach (var symbol in list)
            {
                sum += (int)symbol;
            }

            return sum;
        }
    }
}
