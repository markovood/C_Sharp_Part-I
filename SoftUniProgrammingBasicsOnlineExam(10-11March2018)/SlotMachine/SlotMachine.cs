using System;

namespace SlotMachine
{
    public class SlotMachine
    {
        public static void Main()
        {
            char n = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int result1Pair = n1 + (int)n;

            char m = char.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int result2Pair = m1 + (int)m;

            char k = char.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());
            int result3Pair = k1 + (int)k;

            string finalResult = string.Empty;
            finalResult += (char)result1Pair;
            finalResult += (char)result2Pair;
            finalResult += (char)result3Pair;

            Console.WriteLine(finalResult);
            if (finalResult == "777")
            {
                Console.WriteLine("*** JACKPOT ***");
            }
            else if (finalResult == "@@@")
            {
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }
        }
    }
}
