using System;
using System.Globalization;
using System.Threading;

namespace Problem5.BitsToBits
{
    class BitsToBits
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            byte N = byte.Parse(Console.ReadLine());

            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int mask = 1;
            int position = 29;
            int bitExtract = 0;
            string last30BitsOfAllNumbersTogether = "";
            char[] separator = new char[] { '0', '1' };

            foreach (int number in numbers)
            {
                for (int j = 0; j < 30; j++)
                {
                    bitExtract = (number >> position) & mask;
                    last30BitsOfAllNumbersTogether += bitExtract;
                    position--;
                }
                position = 29;
            }

            // finds longest sequence of 0s
            string[] zeros = last30BitsOfAllNumbersTogether.Split('1');

            int zerosSeq = 0;
            for (int i = 0; i < zeros.Length; i++)
            {
                if (zeros[i].Length > zerosSeq)
                {
                    zerosSeq = zeros[i].Length;
                }
            }

            // finds longest sequence of 1s
            string[] ones = last30BitsOfAllNumbersTogether.Split('0');

            int onesSeq = 0;
            for (int i = 0; i < ones.Length; i++)
            {
                if (ones[i].Length > onesSeq)
                {
                    onesSeq = ones[i].Length;
                }
            }

            Console.WriteLine(zerosSeq);
            Console.WriteLine(onesSeq);



        }
    }
}
