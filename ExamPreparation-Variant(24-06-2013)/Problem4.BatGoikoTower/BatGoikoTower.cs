using System;
using System.Globalization;
using System.Threading;

namespace Problem4.BatGoikoTower
{
    class BatGoikoTower
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int H = int.Parse(Console.ReadLine());

            char dash = '-';
            char slash = '/';
            char backSlash = '\\';
            char dot = '.';

            int initialDots = H - 1;
            int middleDots = 0;
            int crossBeamRow = 1;
            int step = 2;

            for (int i = 0; i < H; i++)
            {
                Console.Write(new string(dot, initialDots));
                Console.Write(slash);
                if (i > 0)
                {
                    if (i % crossBeamRow == 0)
                    {
                        Console.Write(new string(dash, middleDots));
                        crossBeamRow += step;
                        step++;
                    }
                    else
                    {
                        Console.Write(new string(dot, middleDots));
                    }
                }
                Console.Write(backSlash);
                Console.WriteLine(new string(dot, initialDots));
                initialDots--;
                middleDots += 2;
            }

        }
    }
}
