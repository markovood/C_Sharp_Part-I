using System;
class UnicodeChar
{
    static void Main()
    {
        // Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

        char symbol = '\u002A';
        Console.WriteLine("Unicode's character for decimal 42 (Hexadecimal 2A) is: " + symbol);
    }
}
