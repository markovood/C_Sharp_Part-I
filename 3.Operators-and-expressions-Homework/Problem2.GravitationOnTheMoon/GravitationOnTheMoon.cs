using System;

namespace Problem2.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            // The gravitational field of the Moon is approximately 17% of that on the Earth.
            // Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

            double weightOnEarth = 53.7;
            double weightOnMoon = weightOnEarth * 0.17;

            Console.WriteLine("The weight of a man on the Earth is {0}kg, and the same man will be {1}kg on the Moon.",weightOnEarth,weightOnMoon);
        }
    }
}
