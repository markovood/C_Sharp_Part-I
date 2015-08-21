using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem3.Maslan
{
    class Maslan
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            BigInteger initialNumber = BigInteger.Parse(Console.ReadLine());

            int sum = 0;
            BigInteger product = 1;
            int transformation = 0;
            BigInteger currentNumber = initialNumber;

            while (true)
            {

                while (currentNumber > 9)
                {
                    //remove last digit
                    currentNumber /= 10;
                    string currentNumberAsText = currentNumber.ToString();

                    for (int i = 1; i < currentNumberAsText.Length; i += 2)
                    {
                        // sums the odd positions
                        sum += (currentNumberAsText[i] - '0');

                    }

                    if (sum == 0)
                    {
                        break;
                    }
                    product *= sum;
                    sum = 0;


                }

                transformation++;

                if (product <= 9)
                {
                    Console.WriteLine(transformation);
                    Console.WriteLine(product);
                    return;
                }
                else if (transformation == 10)
                {
                    Console.WriteLine(product);
                    return;
                }
                else
                {
                    currentNumber = product;
                    product = 1;
                }
            }

        }
    }
}
