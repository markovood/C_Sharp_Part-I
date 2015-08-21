using System;
using System.Globalization;
using System.Threading;

namespace Problem4.Fire
{
    class Fire
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int N = int.Parse(Console.ReadLine());

            char hashTag = '#';
            char dash = '-';
            char slash = '/';
            char backSlash = '\\';
            char dot = '.';

            int counter1 = ((N - 2) / 2) - 1;
            int counter2 = 2;

            // top
            Console.Write(new string(dot, (N - 2) / 2));
            Console.Write(new string(hashTag, 2));
            Console.WriteLine(new string(dot, (N - 2) / 2));

            for (int i = counter1; i >= 1; i--)
            {
                Console.Write(new string(dot, counter1));
                Console.Write(hashTag);
                Console.Write(new string(dot, counter2));
                Console.Write(hashTag);
                Console.WriteLine(new string(dot, counter1));
                counter1--;
                counter2 += 2;
            }

            // middle of fire
            for (int i = 0; i < 2; i++)
            {
                Console.Write(hashTag);
                Console.Write(new string(dot, N - 2));
                Console.WriteLine(hashTag);
            }

            counter1++;
            counter2 -= 2;

            for (int i = 0; i < (N / 4) - 1; i++)
            {
                Console.Write(new string(dot, counter1));
                Console.Write(hashTag);
                Console.Write(new string(dot, counter2));
                Console.Write(hashTag);
                Console.WriteLine(new string(dot, counter1));
                counter1++;
                counter2 -= 2;
            }

            // middle
            Console.WriteLine(new string(dash, N));

            int slashCounter = N / 2;

            Console.Write(new string(backSlash, slashCounter));
            Console.WriteLine(new string(slash, slashCounter));

            counter1 = 1;
            slashCounter--;

            for (int i = 0; i < (N - 2) / 2; i++)
            {
                Console.Write(new string(dot, counter1));
                Console.Write(new string(backSlash, slashCounter));
                Console.Write(new string(slash, slashCounter));
                Console.WriteLine(new string(dot, counter1));
                counter1++;
                slashCounter--;
            }
        }
    }
}
