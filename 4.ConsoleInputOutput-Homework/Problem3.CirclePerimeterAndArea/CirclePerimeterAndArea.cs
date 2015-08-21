using System;
using System.Threading;
using System.Globalization;
using System.Text;

namespace Problem3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            // Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("This is a program for calculating the perimeter and area of a circle by entered radius");
            Console.WriteLine();
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = Math.PI * (radius * 2);
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine();
            Console.WriteLine("The perimeter of circle with radius {0}cm is: {1:0.00}cm",radius,perimeter);
            Console.WriteLine();
            Console.WriteLine("The area of circle with radius {0}cm is: {1:0.00}cm\u00B2",radius,area);

        }
    }
}
