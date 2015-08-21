using System;
using System.Threading;
using System.Globalization;

namespace Problem6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            // Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            string separator = new string('*', 55);

            double discriminant = Math.Pow(b, 2) - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine(separator);
                Console.WriteLine("No real roots!");
                Console.WriteLine();
            }

            else if(discriminant == 0)
            {
                double realRoot1=-b/(2*a);
                Console.WriteLine(separator);
                Console.WriteLine("Has 1 real root : {0}",realRoot1);
                Console.WriteLine();
            }

            else
            {
                double realRoot1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double realRoot2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine(separator);
                Console.WriteLine("Has 2 real roots: \n>>first {0}\n>>second {1}",realRoot1,realRoot2);
                Console.WriteLine();
            }
        }
    }
}
