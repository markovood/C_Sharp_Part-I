using System;
using System.Text;

namespace Problem9.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            // Write an expression that calculates trapezoid's area by given sides a and b and height h.

            Console.Title = "Trapezoid's area...";
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter trapezoid's side a: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter trapezoid's side b: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Enter trapezoid's height h: ");
            double heightH = double.Parse(Console.ReadLine());

            double area = ((sideA + sideB) * heightH) / 2;    // Formula for calculating trapezoid's area ((a+b)*h)/2
            Console.WriteLine("Trapezoid with measures a={0}cm , b={1}cm , h={2}cm has area of " + area + "cm\u00B2",sideA,sideB,heightH);
        }
    }
}
