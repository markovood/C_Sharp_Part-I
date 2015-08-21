using System;

namespace Problem13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            // Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
            // in given integer number n, has value of 1.

            Console.Title = "Write a Boolean expression that returns if the bit at position p in given integer number n, has value of 1";

            Console.Write("Enter number: ");
            ushort number = ushort.Parse(Console.ReadLine());               // Using ushort type just to match the examples!!!

            Console.Write("Enter position: ");
            ushort position = ushort.Parse(Console.ReadLine());

            ushort mask = 1;
            bool bitCheck = (((number >> position) & mask) == 1);

            string proof = Convert.ToString(number, 2);

            Console.WriteLine("The bit at position {0} is 1 --> {1}",position,bitCheck);
            Console.WriteLine("See for yourself: {0}",proof.PadLeft(16,'0'));
        }
    }
}
