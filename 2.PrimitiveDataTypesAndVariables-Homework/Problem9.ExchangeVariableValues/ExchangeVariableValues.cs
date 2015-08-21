using System;
class ExchangeVariableValues
{
    static void Main()
    {
        // Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
        // Print the variable values before and after the exchange.

        // Variant 1

        //int a = 5;
        //int b = 10;

        //Console.WriteLine("Before:\na = {0}\nb = {1}\n",a,b);

        //a = a + b;
        //b = a - b;
        //a = a - b;

        //Console.WriteLine("After:\na = {0}\nb = {1}\n", a, b);

        // Variant 2

        int a = 5;
        int b = 10;
        int temp;

        Console.WriteLine("Before:\na = {0}\nb = {1}\n",a,b);

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After:\na = {0}\nb = {1}\n", a, b);
    }
}
