using System;

namespace Problem10.PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main()
        {
            // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
            // and out of the rectangle R(top=1, left=-1, width=6, height=2).
            
            Console.Write("Please specify the x coordinate: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Please specify the y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            bool inCircle;
            bool outOfRect;

            if (Math.Sqrt( (Math.Pow(x-1, 2)) + (Math.Pow(y-1, 2)) ) <= 1.5)                                                
            {
                inCircle = true;                                                                                        
            }                                                                                                               
                                                                                                                             
            else                                                                                                            
            {
                inCircle = false;
            }

            if (((x < -1) || (x > 5) || (y > 1) || (y < -1)))
            {
                outOfRect = true;
            }

            else
            {
                outOfRect = false;
            }

            bool result = inCircle && outOfRect;

            Console.WriteLine("The specified point is inside a circle K ((1, 1), 1.5) and outside a rectangle R (top=1, left=-1, width=6, height=2) --> " + result);

        }
    }
}
