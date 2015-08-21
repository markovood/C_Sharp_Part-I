using System;
using System.Text;

namespace Problem4.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            // Write an expression that calculates rectangle’s perimeter and area by given width and height.

            Console.OutputEncoding = Encoding.UTF8;     // This is to fix the right visualization on the console of cm2

            int width = 5;
            int height = 6;

            int perimeter = (width * 2) + (height * 2);
            int area = width * height;

            Console.WriteLine("The perimeter of rectangular with width: " + width + "cm and height: " + height + "cm is ---> " + perimeter + "cm");
            Console.WriteLine("The area of rectangular with width: " + width + "cm and height: " + height + "cm is ---> " + area + "cm\u00B2");
        }
    }
}
