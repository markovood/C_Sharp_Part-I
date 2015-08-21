using System;
using System.Globalization;
using System.Threading;

namespace Problem5.FindBits
{
    class FindBits
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

            // finds the most right 5 bits of S
            string last5BitsOfS = "";

            int mask = 1;
            int position = 4;

            for (int i = 0; i < 5; i++)
            {
                last5BitsOfS += (S >> position) & mask;
                position--;
            }

            // finds the most right 29 bits of each number
            string[] last29BitsOfNumbers = new string[numbers.Length];

            position = 28;
            byte index = 0;

            foreach (int number in numbers)
            {
                for (int i = position; i >= 0; i--)
                {
                    last29BitsOfNumbers[index] += ((number >> i) & mask).ToString();
                }
                index++;
            }

            // find all occurrences
            int countOccurences = 0;
            string temp = "";

            foreach (string last29BitsOfnumber in last29BitsOfNumbers)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (last29BitsOfnumber[i] == last5BitsOfS[0])
                    {
                        temp = "";
                        for (int j = 0; j <= 4; j++)
                        {
                            temp += last29BitsOfnumber[i + j].ToString();
                        }

                        if (temp == last5BitsOfS)
                        {
                            countOccurences++;
                        }
                    }
                }
            }

            Console.WriteLine(countOccurences);

        }
    }
}
