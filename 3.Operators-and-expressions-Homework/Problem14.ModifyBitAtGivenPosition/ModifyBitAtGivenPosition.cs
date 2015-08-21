using System;

namespace Problem14.ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            // We are given an integer number n, a bit value v (v=0 or 1) and a position p.
            // Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
            // at the position p from the binary representation of n while preserving all other bits in n.

            Console.Title = "Modify Bit At Given Position";

            Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();
            int number=int.Parse(userInput);

            Console.WriteLine("Enter bit value 0/1 : ");
            int bitValue=int.Parse(Console.ReadLine());

            if ((bitValue < 0) || (bitValue > 1))                                           // Checks if bit get value different than 0 or 1
            {
                Console.WriteLine("The value of a bit can only be 1 or 0 !!!\nTry again...");
            }

            else
            {
                Console.WriteLine("Enter position: ");
                int position = int.Parse(Console.ReadLine());

                int mask = 1;
                int bitAtPosition = ((number >> position) & mask);                          // Checks which bit is in entered position
                
                bitAtPosition ^= bitValue;                                                  // Changes the value of the bit at entered position with entered value
               
                int result = bitAtPosition << position;                                     // Gets the new bit value at original position
                int newNumber = result ^= number;                                           // Changing the new bit value with the old one

                Console.WriteLine("The number {0} changes into number {1} after we change bit at position {2} with the value {3}",number,newNumber,position,bitValue);  // Prints the new number
                
                string originalNumber=Convert.ToString(number,2);
                string numAfterChange=Convert.ToString(newNumber,2);
                Console.WriteLine("See for yourself {0} --> {1}",originalNumber.PadLeft(32,'0'),numAfterChange.PadLeft(32,'0'));
            }

        }
    }
}
