using System;
using System.Globalization;
using System.Threading;

namespace Problem4.Cube3D
{
    class Cube3D
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte N = byte.Parse(Console.ReadLine());

            byte width = N;
            byte height = N;
            byte depth = N;

            char faceFiller = ' ';
            char heightExtensionFiller = '|';
            char widthExtensionFiller = '-';
            char sides = ':';

            // prints the face and upper part of height extension
            Console.WriteLine(new string(sides, width));

            for (int i = 0; i < width - 2; i++)
            {
                Console.Write(sides);
                Console.Write(new string(faceFiller, (height - 2)));
                Console.Write(sides);
                Console.Write(new string(heightExtensionFiller, i));
                Console.WriteLine(sides);
            }

            Console.Write(new string(sides, width));
            Console.Write(new string(heightExtensionFiller, (width - 2)));
            Console.WriteLine(sides);

            byte counts = (byte)((width - 2) - 1);
            // prints the width extension lower part of height extension
            for (int i = 1; i <= height - 2; i++)
            {
                Console.Write(new string(faceFiller, i));
                Console.Write(sides);
                Console.Write(new string(widthExtensionFiller, (width - 2)));
                Console.Write(sides);
                Console.Write(new string(heightExtensionFiller, counts));
                Console.WriteLine(sides);
                counts--;
            }

            Console.Write(new string(faceFiller, (width - 1)));
            Console.WriteLine(new string(sides, width));
        }
    }
}
