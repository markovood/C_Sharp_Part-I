using System;
class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i <= 17; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ",");
            }

            else
            {
                Console.Write(-i + ",");
            }
        }

        // This is just to place the "Press any key to continue..." on a new line
        Console.WriteLine();
    }
}
