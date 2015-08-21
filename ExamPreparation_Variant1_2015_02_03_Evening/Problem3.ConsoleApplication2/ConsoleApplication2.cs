using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem3.ConsoleApplication2
{
    class ConsoleApplication2
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string line = Console.ReadLine();

            int position = 0;
            BigInteger product = 1;
            short inputs = 1;
            BigInteger productOfFirstTen = 1;
            BigInteger productOfTheRest = 1;

            while (line != "END")
            {
                if (position % 2 == 0)
                {
                    if (line == "0")
                    {
                        product = 1;
                    }
                    else
                    {
                        product = 1;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == '0')
                            {
                                continue;
                            }
                            product *= byte.Parse(line[i].ToString());
                        }
                    }
                }
                else
                {
                    product = 1;
                }

                if (inputs <= 10)
                {
                    productOfFirstTen *= product;
                }
                else
                {
                    productOfTheRest *= product;
                }

                position++;
                inputs++;
                line = Console.ReadLine();
            }

            if (inputs<=10)
            {
                Console.WriteLine(productOfFirstTen);
            }
            else
            {
                Console.WriteLine(productOfFirstTen);
                Console.WriteLine(productOfTheRest);
            }
        }
    }
}
