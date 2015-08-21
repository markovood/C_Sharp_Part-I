using System;
using System.Globalization;
using System.Threading;

namespace Problem7.Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            // Write a program that enters 3 real numbers and prints them sorted in descending order.
            // Use nested if statements.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter 3 numbers and see how they are ordered in descending order");
            Console.WriteLine();

            Console.Write("Enter number 1: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            double third = double.Parse(Console.ReadLine());

            double biggest = 0.0;       // Just giving initial default values
            double smallest = 0.0;
            double middle = 0.0;

            if (first > second)                                                 // Finds the biggest of the three numbers
            {
                if (first > third)
                {
                    biggest = first;
                }
                else
                {
                    biggest = third;
                }
            }
            else
            {
                if (second > third)
                {
                    biggest = second;
                }
                else
                {
                    biggest = third;
                }
            }

            if (first < second)                                                 // Finds the smallest of the three numbers
            {
                if (first < third)
                {
                    smallest = first;
                }
                else
                {
                    smallest = third;
                }
            }
            else
            {
                if (second < third)
                {
                    smallest = second;
                }
                else
                {
                    smallest = third;
                }
            }

            if (biggest == first && smallest == third)              // Sets the middle number 
            {
                middle = second;
            }
            if (biggest == first && smallest == second)
            {
                middle = third;
            }
            if (biggest == second && smallest == third)
            {
                middle = first;
            }
            if (biggest == third && smallest == first)
            {
                middle = second;
            }
            if (biggest == second && smallest == first)
            {
                middle = third;
            }
            if (biggest == third && smallest == second)
            {
                middle = first;
            }

            Console.WriteLine("The numbers you entered in descending order are as follows: {0} {1} {2}", biggest, middle, smallest);
        }
    }
}
