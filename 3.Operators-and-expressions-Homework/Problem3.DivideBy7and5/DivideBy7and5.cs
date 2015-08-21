using System;

namespace Problem3.DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            // Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

            int number = 140;

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("The number " + number + " IS dividable by 7 and 5 at the same time");
            }

            else
            {
                Console.WriteLine("The number " + number + " IS NOT dividable by 7 and 5 at the same time");
            }
        }
    }
}
