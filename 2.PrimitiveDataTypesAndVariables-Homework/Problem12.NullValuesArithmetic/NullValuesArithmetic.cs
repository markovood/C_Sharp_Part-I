using System;
class NullValuesArithmetic
{
    static void Main()
    {
        // Create a program that assigns null values to an integer and to a double variable.
        // Try to print these variables at the console.
        // Try to add some number or the null literal to these variables and print the result.

        int? a;
        double? b;

        Console.Write("Enter an integer type number: ");
        string userInputInteger = Console.ReadLine();
        Console.Write("Enter a double type number (use \",\" as decimal point): ");
        string userInputDouble = Console.ReadLine();

        if (userInputInteger.Length == 0)
        {
            a = null;
        }

        else
        {
            a = Convert.ToInt32(userInputInteger);
        }

        if (userInputDouble.Length == 0)
        {
            b = null;
        }

        else
        {
            b = Convert.ToDouble(userInputDouble);
        }

        Console.WriteLine("Entered data: ");

        if (a == null)
        {
            Console.WriteLine(a.GetValueOrDefault());
        }

        else
        {
            Console.WriteLine(a.Value);
        }

        if (b == null)
        {
            Console.WriteLine(b.GetValueOrDefault());
        }

        else
        {
            Console.WriteLine(b.Value);
        }
    }
}
