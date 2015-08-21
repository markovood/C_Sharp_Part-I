using System;
using System.Text;
class ComparingFloats
{
    static void Main()
    {
        // Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001

        // Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
        // Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Please enter a real floating-point number (double type): ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter a real floating-point number (double type): ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool isEqual = Math.Abs(x - y) < 0.000001;

        Console.WriteLine("Is {0} = {1} \u00BB {2}", x, y, isEqual);
    }
}
