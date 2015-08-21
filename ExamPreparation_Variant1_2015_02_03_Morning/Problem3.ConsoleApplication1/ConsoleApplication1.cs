using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem3.ConsoleApplication1
{
    class ConsoleApplication1
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string line = Console.ReadLine();
            int position = 0;
            BigInteger productOfAllDigits = 1;
            BigInteger productOfFirstTen = 1;
            BigInteger productOfAllOthers = 1;
            int count = 1;

            while (line != "END")
            {
                string currentNumber = line;

                if (position % 2 != 0)
                {
                    if (currentNumber == "0")
                    {
                        productOfAllDigits = 1;
                    }
                    else
                    {
                        for (int i = 0; i < currentNumber.Length; i++)
                        {
                            if (currentNumber[i] == '0')
                            {
                                continue;
                            }
                            productOfAllDigits *= currentNumber[i] - '0';
                        }
                    }
                }

                if (count <= 10)
                {
                    productOfFirstTen *= productOfAllDigits;
                    productOfAllDigits = 1;
                }
                else
                {
                    productOfAllOthers *= productOfAllDigits;
                    productOfAllDigits = 1;
                }

                position++;
                count++;

                line = Console.ReadLine();
            }

            if (count <= 10)
            {
                Console.WriteLine(productOfFirstTen);
            }
            else
            {
                Console.WriteLine(productOfFirstTen);
                Console.WriteLine(productOfAllOthers);
            }
        }
    }
}
