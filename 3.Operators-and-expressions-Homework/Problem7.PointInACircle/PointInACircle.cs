using System;

namespace Problem7.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

            Console.Write("Please specify the x coordinate: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Please specify the y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            if (Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2))) <= 2)                                                        // Използваме Питагоровата теорема, тъй като тя дава
            {                                                                                                               // зависимостта на хипотенузата(най-дългата страна на 
                Console.WriteLine("The specified point with coordinates ({0},{1}) IS INSIDE a circle K(0, 0), 2", x, y);    // триъгълник "с") и другите две страни ("а" и "в") на 
            }                                                                                                               // правоъгълен триъгълник, а в нашият случай хипотенуза 
                                                                                                                            // е разстоянието от точката до центъра на окръжността т.е.   
            else                                                                                                            // радиуса, а страните са перпендикулярите спуснати от 
            {                                                                                                               // точката към координатната система, съответно по "х" и "у".
                Console.WriteLine("The specified point with coordinates ({0},{1}) is NOT INSIDE a circle K(0, 0), 2", x, y); 
            }
        }
    }
}
