using System;

namespace Balls
{
    public class Balls
    {
        public static void Main()
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            int totalPts = 0;
            int R= 0;
            int O = 0;
            int Y = 0;
            int W = 0;
            int B = 0;
            int others = 0;
            
            for (int i = 0; i < numberOfBalls; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        totalPts += 5;
                        R++;
                        break;
                    case "orange":
                        totalPts += 10;
                        O++;
                        break;
                    case "yellow":
                        totalPts += 15;
                        Y++;
                        break;
                    case "white":
                        totalPts += 20;
                        W++;
                        break;
                    case "black":
                        totalPts /= 2;
                        B++;
                        break;
                    default:
                        others++;
                        break;
                }
            }

            Console.WriteLine("Total points: {0}", totalPts);
            Console.WriteLine("Points from red balls: {0}", R);
            Console.WriteLine("Points from orange balls: {0}", O);
            Console.WriteLine("Points from yellow balls: {0}", Y);
            Console.WriteLine("Points from white balls: {0}", W);
            Console.WriteLine("Other colors picked: {0}", others);
            Console.WriteLine("Divides from black balls: {0}", B);
        }
    }
}
