using System;

namespace Problem11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            // Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
            // The bits are counted from right to left, starting from bit #0.
            // The result of the expression should be either 1 or 0.

            Console.Title = "Write an expression for finding the value of the bit #3 of a given unsigned integer".ToUpper();

            Console.Write("Enter number to check bit#3: ");
            uint userInput = uint.Parse(Console.ReadLine());

            uint mask = 1;

            uint bitValue = (userInput >> 3) & mask;

            Console.WriteLine("The value of bit#3 is: " + bitValue);
        }
    }
}
