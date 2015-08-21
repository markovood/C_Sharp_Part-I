using System;
using System.Text;
class PrintTheAsciiTable
{
    static void Main()
    {
        // Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire 
        // ASCII table of characters on the console (characters from 0 to 255).

        Console.Title = "ASCII Table";
        Console.OutputEncoding = Encoding.UTF8; // This is to print the characters correctly...

        for (int i = 0; i < 256; i++)
        {
            char symbol = (char)i;
            
            if (i>=0 && i<32)
            {
                Console.Write(" Control,");
            }

            else if (i == 32)
            {
                Console.Write(" Space Control,");
            }

            else if (i == 127)
            {
                Console.Write(" Delete Control,");
            }

            else if (i == 129 || i==141 || i==143 || i==144 || i==157)
            {
                Console.Write(" Unassigned,");
            }

            else if (i == 160)
            {
                Console.Write(" Non-breaking space Control,");
            }

            else
            {
                Console.Write(" " + symbol + ",");
            }
        }

        Console.WriteLine("\n\n\n");    // This is to put the "Press any key to continue..." away from the printout
    }
}
