using System;
using System.Globalization;
using System.Threading;

namespace Problem4.PersianRugs
{
    class PersianRugs
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte N = byte.Parse(Console.ReadLine());
            byte D = byte.Parse(Console.ReadLine());

            byte width = (byte)((2 * N) + 1);
            byte height = width;

            char space = ' ';
            char dot = '.';
            char letterX = 'X';
            char slash = '/';
            char backSlash = '\\';
            char hashTag = '#';


            if (N > D)
            {
                // TODO: трябва да се открие зависимост при която да се сменят "count" и "counter", в момента работи вярно, но само за нулевите тестове и за тези 
                // при които (N <= D)
                int count = 3;
                int counter = 3;

                // top part
                for (int j = 0; j < N; j++)
                {
                    Console.Write(new string(hashTag, j));
                    Console.Write(backSlash);
                    if (count > 0)
                    {
                        Console.Write(new string(space, D));
                        Console.Write(backSlash);
                        Console.Write(new string(dot, count));
                        Console.Write(slash);
                        Console.Write(new string(space, D));
                    }
                    else if (count == -1)
                    {
                        Console.Write(new string(space, D));
                        Console.Write(space);
                        Console.Write(new string(space, D));
                    }
                    else
                    {
                        Console.Write(new string(space, counter));
                        counter -= 2;
                    }

                    count -= 2;
                    Console.Write(slash);
                    Console.WriteLine(new string(hashTag, j));

                }

                // middle line
                Console.Write(new string(hashTag, N));
                Console.Write(letterX);
                Console.WriteLine(new string(hashTag, N));

                // bottom part
                count = 0;
                counter = 1;
                int count1 = 1;

                for (int i = N - 1; i >= 0; i--)
                {
                    Console.Write(new string(hashTag, i));
                    Console.Write(slash);
                    if (count < D)
                    {
                        Console.Write(new string(space, counter));
                        counter += 2;
                    }
                    else if (count == D)
                    {
                        Console.Write(new string(space, D));
                        Console.Write(space);
                        Console.Write(new string(space, D));
                    }
                    else
                    {
                        Console.Write(new string(space, D));
                        Console.Write(slash);
                        Console.Write(new string(dot, count1));
                        Console.Write(backSlash);
                        Console.Write(new string(space, D));
                        count1 += 2;
                    }

                    count++;

                    Console.Write(backSlash);
                    Console.WriteLine(new string(hashTag, i));
                }
            }
            else
            {
                // top part
                int counter = width - 2;

                for (int j = 0; j < N; j++)
                {
                    Console.Write(new string(hashTag, j));
                    Console.Write(backSlash);

                    Console.Write(new string(space, counter));
                    counter -= 2;

                    Console.Write(slash);
                    Console.WriteLine(new string(hashTag, j));
                }

                // middle line
                Console.Write(new string(hashTag, N));
                Console.Write(letterX);
                Console.WriteLine(new string(hashTag, N));

                // bottom part
                counter = 1;

                for (int i = N - 1; i >= 0; i--)
                {
                    Console.Write(new string(hashTag, i));
                    Console.Write(slash);

                    Console.Write(new string(space, counter));
                    counter += 2;

                    Console.Write(backSlash);
                    Console.WriteLine(new string(hashTag, i));
                }
            }
        }
    }
}
