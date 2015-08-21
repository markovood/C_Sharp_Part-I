using System;
using System.Globalization;
using System.Threading;

namespace Problem4.Cubes
{
    class Cubes
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte N = byte.Parse(Console.ReadLine());

            byte width = N;
            byte height = N;
            byte depth = N;

            char sides = ':';
            char top = '/';
            char aside = 'X';
            char face = ' ';

            byte elongation = (byte)(N - 1);

            // create this variable to make possible filling up the aside later on
            byte count = 1;

            // top depth
            for (int i = 0; i < N; i++)
            {
                // Print the spaces
                Console.Write(new string(face, elongation - i));
                if (i > 0 && i < elongation)
                {
                    Console.Write(sides);
                    for (int j = 1; j <= height - 2; j++)
                    {
                        Console.Write(top);
                    }
                    Console.Write(sides);
                    if (i > 1 && i < elongation)
                    {
                        // fill up the aside
                        for (int j = 1; j <= count; j++)
                        {
                            Console.Write(aside);
                        }
                        count++;
                    }
                    Console.WriteLine(sides);
                }
                else
                {
                    if (i == elongation)
                    {
                        Console.Write(new string(sides, N));
                        Console.Write(new string(aside, N - 2));
                        Console.WriteLine(sides);
                    }
                    else
                    {
                        Console.WriteLine(new string(sides, N));
                    }
                }
            }


            // left and right front sides --> heights
            for (int i = 1; i <= height - 2; i++)
            {
                Console.Write(sides);

                // fill in the face
                for (int j = 1; j <= width - 2; j++)
                {
                    Console.Write(face);
                }

                Console.Write(sides);

                for (int k = 1; k <= (depth - 2) - 1; k++)
                {
                    Console.Write(aside);
                }
                depth--;
                Console.WriteLine(sides);
            }

            // bottom side 
            Console.WriteLine(new string(sides, N));
            
        }
    }
}
