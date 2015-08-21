using System;

namespace Problem5.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            // Write an expression that checks for given integer if its third digit from right-to-left is 7.

            Console.Write("Please enter a number... ");
            int number = int.Parse(Console.ReadLine());

            int thirdDigit = ((number / 10) / 10) % 10;
            bool isSeven = true;

            if (thirdDigit == 7)
            {
                Console.WriteLine("The third digit right-to-left is 7 --> " + isSeven);
            }

            else
            {
                Console.WriteLine("The third digit right-to-left is 7 --> " + !isSeven);
            }
        }
    }
}
