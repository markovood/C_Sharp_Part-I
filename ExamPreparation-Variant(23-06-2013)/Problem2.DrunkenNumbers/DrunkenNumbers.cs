using System;
using System.Globalization;
using System.Threading;

namespace Problem2.DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte N = byte.Parse(Console.ReadLine());

            long[] numbers = new long[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
                if (numbers[i] < 0)
                {
                    numbers[i] *= -1;
                }
            }

            int index = 0;
            string[] numbersAsText = new string[numbers.Length];
            foreach (var number in numbers)
            {
                numbersAsText[index] = number.ToString();
                index++;
            }


            int mitkoBeers = 0;
            int vladkoBeers = 0;
            foreach (var numberAsText in numbersAsText)
            {
                if (numberAsText.Length % 2 == 0)
                {
                    for (int i = 0; i < numberAsText.Length / 2; i++)
                    {
                        mitkoBeers += (numberAsText[i] - '0');
                    }

                    for (int i = numberAsText.Length / 2; i < numberAsText.Length; i++)
                    {
                        vladkoBeers += (numberAsText[i] - '0');
                    }
                }
                else
                {
                    for (int i = 0; i <= numberAsText.Length / 2; i++)
                    {
                        mitkoBeers += (numberAsText[i] - '0');
                    }

                    for (int i = numberAsText.Length / 2; i < numberAsText.Length; i++)
                    {
                        vladkoBeers += (numberAsText[i] - '0');
                    }
                }
            }

            if (mitkoBeers > vladkoBeers)
            {
                Console.WriteLine("M {0}", mitkoBeers - vladkoBeers);
            }
            else if (vladkoBeers > mitkoBeers)
            {
                Console.WriteLine("V {0}", vladkoBeers - mitkoBeers);
            }
            else if (mitkoBeers == vladkoBeers)
            {
                Console.WriteLine("No {0}", mitkoBeers + vladkoBeers);
            }
        }
    }
}
