using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem3.SaddyKopper
{
    class SaddyKopper
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            BigInteger numberFromPublic = BigInteger.Parse(Console.ReadLine());

            int countTransformation = 0;

            while (true)
            {


                // removes the last digit 
                BigInteger currentNumber = numberFromPublic / 10;

                string currentNumberAsText = currentNumber.ToString();
                int[] digitAtEvenPosition = new int[currentNumberAsText.Length];


                // finds all digits at even positions 
                for (int i = 0; i < currentNumberAsText.Length; i += 2)
                {
                    if (i % 2 == 0)
                    {
                        digitAtEvenPosition[i] = currentNumberAsText[i] - '0';
                    }
                }

                // finds their sum
                int sum = 0;
                for (int i = 0; i < digitAtEvenPosition.Length; i++)
                {
                    sum += digitAtEvenPosition[i];
                }

                // finds the product of all sums
                BigInteger product = 1;
                product *= sum;

                int lastIndex = digitAtEvenPosition.Length - 1;

                // continue removing last digit until only one number left and it is with one digit
                for (BigInteger i = currentNumber; i > 9; i /= 10)
                {
                    // removes the last digit
                    currentNumber = currentNumber / 10;
                    currentNumberAsText = currentNumber.ToString();

                    // finds all digits at even positions 
                    for (int j = 0; j < currentNumberAsText.Length; j+=2)
                    {
                        if (j % 2 == 0)
                        {
                            digitAtEvenPosition[j] = currentNumberAsText[j] - '0';
                        }
                    }

                    // set the last position to 0 so it doesn't affect the sum later
                    digitAtEvenPosition.SetValue(0, lastIndex);
                    lastIndex--;

                    // finds their sum
                    sum = 0;
                    for (int k = 0; k < digitAtEvenPosition.Length; k++)
                    {
                        sum += digitAtEvenPosition[k];
                    }

                    // finds the product of all sums
                    product *= sum;
                }

                BigInteger finalResult = product;
                countTransformation++;




                // check product of all sums - if is one digit stops the trick,else starts over with the new number
                if (finalResult <= 9)
                {
                    Console.WriteLine(countTransformation);
                    Console.WriteLine(finalResult);
                    return;
                }
                else
                {
                    // Start over with the finalResult
                    numberFromPublic = finalResult;
                }

                if (countTransformation == 10)
                {
                    Console.WriteLine(finalResult);
                    return;
                }


            }
        }
    }
}
