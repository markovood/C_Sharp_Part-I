using System;
using System.Globalization;
using System.Threading;

namespace Problem2.Decoding
{
    class Decoding
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte SALT = byte.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double[] encodedText = new double[text.Length - 1]; // [text.Length-1] since we don't need the last char-@
            int index = 0;


            foreach (char symbol in text)
            {
                if (symbol == '@')
                {
                    break;
                }
                else if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol < 'Z'))
                {
                    encodedText[index] = (symbol * SALT) + 1000;
                }
                else if (symbol >= '0' && symbol <= '9')
                {
                    encodedText[index] = ((symbol + SALT) + 500);
                }
                else
                {
                    encodedText[index] = (symbol - SALT);
                }
                index++;
            }

            for (int i = 0; i < encodedText.Length; i++)
            {

                if (i % 2 == 0)
                {
                    encodedText[i] /= 100;
                    Console.WriteLine("{0:F2}",encodedText[i]);
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
