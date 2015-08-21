using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem2.TheSecretsOfNumbers
{
    class TheSecretsOfNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            BigInteger N = BigInteger.Parse(Console.ReadLine());
            if (N < 0)
            {
                N *= -1;
            }
            string nToString = Convert.ToString(N);

            int specialSum = 0;
            string alfaSequence = "";

            // Calculate the special sum
            int index = nToString.Length - 1;
            for (int i = 1; i <= nToString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    specialSum += ((int)Math.Pow(nToString[index] - '0', 2.0)) * i;
                }
                else
                {
                    specialSum += (nToString[index] - '0') * ((int)Math.Pow(i, 2.0));
                }
                index--;
            }

            // find the secret alfa-sequence
            int R = specialSum % 26;
            int position = R + 1;
            int alfaSequenceLength = specialSum % 10;

            string alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";    // on 0 position we put "SPACE" just to use the proper positions (1-26) of letters in the alphabet later on

            for (int i = 1; i <= alfaSequenceLength; i++)
            {
                if (position > 26)
                {
                    position = 1;
                }
                alfaSequence += alphabet[position].ToString();
                position++;
            }

            Console.WriteLine(specialSum);
            if (alfaSequenceLength > 0)
            {
                Console.WriteLine(alfaSequence);
            }
            else
            {
                Console.WriteLine("{0} has no secret alpha-sequence", N);
            }
        }
    }
}
