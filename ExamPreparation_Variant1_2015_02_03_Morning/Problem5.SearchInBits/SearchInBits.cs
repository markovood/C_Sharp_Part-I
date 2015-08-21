using System;
using System.Globalization;
using System.Threading;

namespace Problem5.SearchInBits
{
    class SearchInBits
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte S = byte.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());

            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // most right 4 bits of S
            int mask = 1;
            int position = 3;
            int bitCheck = 0;

            string last4BitsOfS = "";

            for (int i = position; i >= 0; i--)
            {
                bitCheck = (S >> i) & mask;
                last4BitsOfS += bitCheck.ToString();
            }

            // most right 30 bits of each number
            string[] last30BitsOfNumbers = new string[N];

            int index = 0;
            foreach (int number in numbers)
            {
                position = 29;

                for (int i = position; i >= 0; i--)
                {
                    bitCheck = (number >> i) & mask;
                    last30BitsOfNumbers[index] += bitCheck.ToString();
                }

                index++;
            }

            int countOccurrences = 0;
            string str = "";

            for (int i = 0; i < last30BitsOfNumbers.Length; i++)
            {
                for (int j = 0; j <= last30BitsOfNumbers[i].Length-last4BitsOfS.Length; j++)
                {
                    if (last30BitsOfNumbers[i][j] == last4BitsOfS[0])
                    {
                        str = "";
                        for (int k = 0; k < 4; k++)
                        {
                            str += last30BitsOfNumbers[i][j + k].ToString();
                        }
                        if (str == last4BitsOfS)
                        {
                            countOccurrences++;
                        }
                    }
                }
            }

            Console.WriteLine(countOccurrences);
        }
    }
}
