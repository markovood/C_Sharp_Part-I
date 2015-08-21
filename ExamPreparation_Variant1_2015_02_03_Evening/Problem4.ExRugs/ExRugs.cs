using System;
using System.Globalization;
using System.Threading;

namespace Problem4.ExRugs
{
    class ExRugs
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte N = byte.Parse(Console.ReadLine());
            byte D = byte.Parse(Console.ReadLine());

            byte width = (byte)((2 * N) + 1);
            byte height = width;

            char space = ' ';
            char letterX = 'X';
            char slash = '/';
            char backSlash = '\\';
            char hashTag = '#';
            char dot = '.';

            if (N > D)
            {
                // middle line
                int dotsLength = ((width - D) / 2) - 1;

                Console.Write(new string(dot, dotsLength));
                Console.Write(letterX);
                Console.Write(new string(hashTag, D));
                Console.Write(letterX);
                Console.WriteLine(new string(dot, dotsLength));

            }
            else
            {
                for (int i = 0; i < height; i++)
                {
                    Console.WriteLine(new string(hashTag, width));
                }
            }



        }
    }
}
