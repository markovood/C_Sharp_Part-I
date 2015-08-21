using System;
using System.Globalization;
using System.Threading;

namespace Problem10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            // You are given n integers (given in a single line, separated by a space).
            // Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            // Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please enter some integers separated by a space...");
            string userInput = Console.ReadLine();

            // Splits the user input by space character and records it into a string array
            string[] n = userInput.Split(' ');

            int oddProduct = 1;
            int evenProduct = 1;

            // Calculates the odd product taking the odd positions (according to the circumstances) and parsing them to an integer number
            for (int i = 0; i < n.Length; i += 2)
            {
                oddProduct *= int.Parse(n[i]);
            }

            // Calculates the even product taking the even positions (according to the circumstances) and parsing them to an integer number
            for (int i = 1; i < n.Length; i += 2)
            {
                evenProduct *= int.Parse(n[i]);
            }

            // Prints final result
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("The product of the odd elements is equal to the product of the even elements: Yes");
                Console.WriteLine("The product is: {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("The product of the odd elements is equal to the product of the even elements: No");
                Console.WriteLine("The odd product is: {0}", oddProduct);
                Console.WriteLine("The even product is: {0}", evenProduct);
            }
        }
    }
}
