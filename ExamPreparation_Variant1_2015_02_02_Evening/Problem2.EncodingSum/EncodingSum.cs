using System;
using System.Globalization;
using System.Threading;

namespace Problem2.EncodingSum
{
    class EncodingSum
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int M = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int result = 0;

            foreach (char currentChar in text)
            {
                if (currentChar == '@')
                {
                    Console.WriteLine(result);
                    return;
                }
                else if (currentChar >= '0' && currentChar <= '9')
                {
                    result *= currentChar - '0';
                }
                else if ((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z'))
                {
                    switch (currentChar)
                    {
                        case 'a':
                        case 'A':
                            result += 0;
                            break;
                        case 'b':
                        case 'B':
                            result += 1;
                            break;
                        case 'c':
                        case 'C':
                            result += 2;
                            break;
                        case 'd':
                        case 'D':
                            result += 3;
                            break;
                        case 'e':
                        case 'E':
                            result += 4;
                            break;
                        case 'f':
                        case 'F':
                            result += 5;
                            break;
                        case 'g':
                        case 'G':
                            result += 6;
                            break;
                        case 'h':
                        case 'H':
                            result += 7;
                            break;
                        case 'i':
                        case 'I':
                            result += 8;
                            break;
                        case 'j':
                        case 'J':
                            result += 9;
                            break;
                        case 'k':
                        case 'K':
                            result += 10;
                            break;
                        case 'l':
                        case 'L':
                            result += 11;
                            break;
                        case 'm':
                        case 'M':
                            result += 12;
                            break;
                        case 'n':
                        case 'N':
                            result += 13;
                            break;
                        case 'o':
                        case 'O':
                            result += 14;
                            break;
                        case 'p':
                        case 'P':
                            result += 15;
                            break;
                        case 'q':
                        case 'Q':
                            result += 16;
                            break;
                        case 'r':
                        case 'R':
                            result += 17;
                            break;
                        case 's':
                        case 'S':
                            result += 18;
                            break;
                        case 't':
                        case 'T':
                            result += 19;
                            break;
                        case 'u':
                        case 'U':
                            result += 20;
                            break;
                        case 'v':
                        case 'V':
                            result += 21;
                            break;
                        case 'w':
                        case 'W':
                            result += 22;
                            break;
                        case 'x':
                        case 'X':
                            result += 23;
                            break;
                        case 'y':
                        case 'Y':
                            result += 24;
                            break;
                        case 'z':
                        case 'Z':
                            result += 25;
                            break;
                    }
                }
                else
                {
                    result %= M;
                }
            }

            Console.WriteLine(result);

        }
    }
}
