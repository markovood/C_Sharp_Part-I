using System;

namespace Problem5.SequenceOfBits
{
    class SequenceOfBits
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());

            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int mask = 1;
            byte position = 29;
            int bitExtract = 0;
            string last30BitsTogether = "";

            // gets bits sequence in reversed order
            foreach (int number in numbers)
            {
                position = 29;
                for (int i = 0; i < 30; i++)
                {
                    bitExtract = (number >> position) & mask;
                    last30BitsTogether += bitExtract.ToString();
                    position--;
                }
            }

            string[] ones = last30BitsTogether.Split('0');
            string[] zeros = last30BitsTogether.Split('1');

            int onesSeq = 0;
            int zerosSeq = 0;

            // Finds longest sequence of 1s
            foreach (string unit in ones)
            {
                if (unit.Length > onesSeq)
                {
                    onesSeq = unit.Length;
                }
            }

            // Finds longest sequence of 0s
            foreach (string zero in zeros)
            {
                if (zero.Length > zerosSeq)
                {
                    zerosSeq = zero.Length;
                }
            }

            Console.WriteLine(onesSeq);
            Console.WriteLine(zerosSeq);
        }
    }
}
