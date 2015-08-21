using System;
using System.Threading;
using System.Globalization;

namespace Problem11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            // Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter 2 positive integers to check how many numbers there are between them dividable by 5 without reminder.");

            Console.Write("Enter number for start: ");
            uint start = uint.Parse(Console.ReadLine());

            
            Console.Write("Enter number for end: ");
            uint end = uint.Parse(Console.ReadLine());
            Console.WriteLine();

            int counter = 0;

            for (uint i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                    // Console.Write("{0}, ",i);            // uncomment this if you want to see the numbers between start and end dividable by 5 with 0 reminder
                }                                           // but add "\n"+ before the separator
                
            }

            string separator = new string('*', 55);
            Console.WriteLine(separator);
            Console.WriteLine("There are {0} numbers dividable by 5 exactly between {1} and {2}.",counter,start,end);
        }
    }
}
