﻿using System;
using System.Globalization;
using System.Threading;

namespace Problem2.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            // Write a program that applies bonus score to given score in the range [1…9] by the following rules:
            // 
            // If the score is between 1 and 3, the program multiplies it by 10.
            // If the score is between 4 and 6, the program multiplies it by 100.
            // If the score is between 7 and 9, the program multiplies it by 1000.
            // If the score is 0 or more than 9, the program prints "Invalid score".

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter your score [1...9] to get a bonus: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                score *= 10;
                Console.WriteLine("Your new score is {0}",score);
            }

            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                Console.WriteLine("Your new score is {0}", score);
            }

            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                Console.WriteLine("Your new score is {0}", score);
            }

            else
            {
                Console.WriteLine("Invalid score!");
            }
        }
    }
}
