using System;
using System.Globalization;
using System.Threading;

namespace Problem4.DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int N = int.Parse(Console.ReadLine());

            int width = N * 2 + 1;
            int height = (6 + ((N - 3) / 2) * 3);

            char asterisk = '*';
            char dot = '.';

            // top line
            Console.Write(new string(dot, (width - N) / 2));
            Console.Write(new string(asterisk, N));
            Console.WriteLine(new string(dot, (width - N) / 2));

            int counter1 = ((width - N) / 2) - 1;
            int counter2 = counter1;
            for (int i = counter1; i > 0; i--)
            {
                Console.Write(new string(dot, counter1));
                Console.Write(asterisk);
                Console.Write(new string(dot, counter2));
                Console.Write(asterisk);
                Console.Write(new string(dot, counter2));
                Console.Write(asterisk);
                Console.WriteLine(new string(dot, counter1));
                counter1--;
                counter2++;
            }

            // middle line
            Console.WriteLine(new string(asterisk, width));

            counter1 = 1;
            counter2 = (N - 1) - 1;
            for (int i = counter2; i >= 0; i--)
            {
                Console.Write(new string(dot, counter1));
                Console.Write(asterisk);
                Console.Write(new string(dot, counter2));
                Console.Write(asterisk);
                Console.Write(new string(dot, counter2));
                Console.Write(asterisk);
                Console.WriteLine(new string(dot, counter1));
                counter1++;
                counter2--;
            }

            // bottom line
            Console.Write(new string(dot, N));
            Console.Write(asterisk);
            Console.WriteLine(new string(dot, N));

        }
    }
}
