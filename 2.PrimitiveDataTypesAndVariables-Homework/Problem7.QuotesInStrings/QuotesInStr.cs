using System;
class QuotesInStr
{
    static void Main()
    {
        // Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
        // Do the above in two different ways - with and without using quoted strings.
        // Print the variables to ensure that their value was correctly defined.

        string firstWay = "The \"use\" of quotations causes difficulties.";         // escaping " with \"
        string secondWay = @"The ""use"" of quotations causes difficulties.";       // escaping " with ""

        Console.WriteLine("{0}\n{1}\n",firstWay,secondWay);
    }
}
