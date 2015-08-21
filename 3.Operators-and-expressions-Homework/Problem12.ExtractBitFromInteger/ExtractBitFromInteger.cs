using System;

namespace Problem12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            // Write an expression that extracts from given integer n the value of given bit at index p.

            Console.Title = "Write an expression that extracts from given integer n the value of given bit at index p".ToUpper();

            Console.Write("Enter an integer number: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.Write("Enter a number for the position you want to extract: ");
            int position = int.Parse(Console.ReadLine());

            int mask = 1;
            int bitExtract = (userInput >> position) & mask;

            Console.WriteLine("The bit at position {0} is: {1}",position,bitExtract);
        }
    }
}
