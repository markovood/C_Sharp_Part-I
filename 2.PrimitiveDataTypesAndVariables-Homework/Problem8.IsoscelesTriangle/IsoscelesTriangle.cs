using System;
class IsoscelesTriangle
{
    static void Main()
    {
        // Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
        //     ©

        //    © ©

        //   ©   ©

        //  © © © ©

        char symbol = '\u00A9';

        Console.OutputEncoding = System.Text.Encoding.UTF8;     // This sets the correct print of the copyright symbol on the console...
        Console.WriteLine("   " + symbol);
        Console.WriteLine();      // Adds the empty line to look exactly like the example...
        Console.WriteLine("  " + symbol + " " + symbol);
        Console.WriteLine();      // Adds the empty line to look exactly like the example...
        Console.WriteLine(" " + symbol + "   " + symbol);
        Console.WriteLine();      // Adds the empty line to look exactly like the example...
        Console.WriteLine(symbol + " " +symbol + " " +symbol + " " +symbol);
    }
}
