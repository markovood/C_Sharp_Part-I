using System;
class PrintLongSequence
{
    static void Main()
    {
        // Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

        for (int i = 2; i <= 1000; i++)
        {
            if (i%2 == 0)
            {
                Console.Write(i + ",");
            }

            else
            {
                Console.Write(-i + ",");
            }
        }


        Console.WriteLine();
    }
}
