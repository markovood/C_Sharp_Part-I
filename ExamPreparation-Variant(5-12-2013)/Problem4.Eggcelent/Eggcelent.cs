using System;
using System.Globalization;
using System.Threading;

namespace Problem4.Eggcelent
{
    class Eggcelent
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte sizeN = byte.Parse(Console.ReadLine());
            byte eggHeight = (byte)(2 * sizeN);
            byte eggWidth = (byte)(3 * sizeN - 1);
            byte canvasWidth = (byte)(3 * sizeN + 1);
            byte canvasHeight = eggHeight;

            byte eggTopSize = (byte)(sizeN - 1);
            byte eggBottomSize = eggTopSize;

            char dot = '.';
            char at = '@';
            char asterisk = '*';

            int dotCounter = eggTopSize;
            int midDotCounter = sizeN;

            if (sizeN > 2)
            {
                // egg's top
                Console.Write(new string(dot, (canvasWidth - eggTopSize) / 2));
                Console.Write(new string(asterisk, eggTopSize));
                Console.WriteLine(new string(dot, (canvasWidth - eggTopSize) / 2));

                for (int i = 1; i <= sizeN - 2; i++)
                {
                    Console.Write(new string(dot, dotCounter));
                    Console.Write(asterisk);
                    Console.Write(new string(dot, midDotCounter + 1));
                    Console.Write(asterisk);
                    Console.WriteLine(new string(dot, dotCounter));
                    dotCounter -= 2;
                    if (dotCounter < 1)
                    {
                        dotCounter = 1;
                    }
                    midDotCounter += 4;
                    if (midDotCounter > (canvasWidth - 5))
                    {
                        midDotCounter = canvasWidth - 5;
                    }
                }

                // egg's middle
                Console.Write("{0}{1}", dot, asterisk);
                for (int i = 1; i <= canvasWidth - 4; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(dot);
                    }
                    else
                    {
                        Console.Write(at);
                    }

                }
                Console.WriteLine("{0}{1}", asterisk, dot);
                Console.Write("{0}{1}", dot, asterisk);
                for (int i = 1; i <= canvasWidth - 4; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(at);
                    }
                    else
                    {
                        Console.Write(dot);
                    }

                }
                Console.WriteLine("{0}{1}", asterisk, dot);


                // egg's bottom
                for (int i = sizeN - 2; i >= 1; i--)
                {
                    Console.Write(new string(dot, dotCounter));
                    Console.Write(asterisk);
                    Console.Write(new string(dot, midDotCounter + 1));
                    Console.Write(asterisk);
                    Console.WriteLine(new string(dot, dotCounter));
                    dotCounter += 2;
                    if (i > ((sizeN - 2) / 2)+1)
                    {
                        dotCounter = 1;
                    }
                    midDotCounter -= 4;
                    if (i > ((sizeN - 2) / 2)+1)
                    {
                        midDotCounter = canvasWidth - 5;
                    }
                }

                Console.Write(new string(dot, (canvasWidth - eggTopSize) / 2));
                Console.Write(new string(asterisk, eggTopSize));
                Console.WriteLine(new string(dot, (canvasWidth - eggTopSize) / 2));

            }
            else
            {
                // egg's top
                Console.Write(new string(dot, (canvasWidth - eggTopSize) / 2));
                Console.Write(new string(asterisk, eggTopSize));
                Console.WriteLine(new string(dot, (canvasWidth - eggTopSize) / 2));


                // egg's middle
                Console.Write("{0}{1}", dot, asterisk);
                for (int i = 1; i <= canvasWidth - 4; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(dot);
                    }
                    else
                    {
                        Console.Write(at);
                    }

                }
                Console.WriteLine("{0}{1}", asterisk, dot);
                Console.Write("{0}{1}", dot, asterisk);
                for (int i = 1; i <= canvasWidth - 4; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(at);
                    }
                    else
                    {
                        Console.Write(dot);
                    }

                }
                Console.WriteLine("{0}{1}", asterisk, dot);


                // egg's bottom
                Console.Write(new string(dot, (canvasWidth - eggTopSize) / 2));
                Console.Write(new string(asterisk, eggTopSize));
                Console.WriteLine(new string(dot, (canvasWidth - eggTopSize) / 2));

            }



        }
    }
}
