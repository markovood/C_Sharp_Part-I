using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem2.TheHorror
{
    class TheHorror
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string text = Console.ReadLine();
            BigInteger counter = 0;
            BigInteger sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if ((text[i] >= 'a' && text[i] <= 'z') || (text[i] >= 'A' && text[i] <= 'Z'))
                    {
                        continue;
                    }
                    else
                    {
                        sum += text[i] - '0';
                        counter++;
                    }
                }
            }

            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
