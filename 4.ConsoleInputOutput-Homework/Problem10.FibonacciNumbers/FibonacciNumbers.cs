using System;
using System.Threading;
using System.Globalization;

namespace Problem10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            // Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and 
            // space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

            // Note: You may need to learn how to use loops.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter the number up to which you want to see the whole Fibonacci sequence: ");
            int number = int.Parse(Console.ReadLine());

            int firstMember = 0;
            int secondMember = 1;
            
            for (int i = 0; i < number; i++)
            {
                Console.Write("{0} ,", firstMember);         // Започва се с 0 и 1, а всеки следващ член на редицата се получава като сума на предходните два. 
                int sum = firstMember + secondMember;
                firstMember = secondMember;
                secondMember = sum;
            }
        }
    }
}
