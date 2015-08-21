using System;
using System.Globalization;
using System.Threading;

namespace Problem2.SymbolToNumber
{
    class SymbolToNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte SECRET = byte.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            decimal[] encodedText = new decimal[text.Length];

            int index = 0;

            foreach (char symbol in text)
            {
                if (symbol == '@')
                {
                    break;
                }
                else if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
                {
                    encodedText[index] = ((symbol * SECRET) + 1000);
                }
                else if (symbol >= '0' && symbol <= '9')
                {
                    encodedText[index] = ((symbol + SECRET) + 500);
                }
                else
                {
                    encodedText[index] = symbol - SECRET;
                }

                index++;
            }

            for (int i = 0; i < encodedText.Length - 1; i++)        // "i < encodedText.Length - 1" because text will always end with @
            {
                if (i % 2 == 0)
                {
                    encodedText[i] /= 100;
                    Console.WriteLine("{0:F2}", encodedText[i]);
                }
                else
                {
                    encodedText[i] *= 100;
                    Console.WriteLine(encodedText[i]);
                }
            }

        }
    }
}
