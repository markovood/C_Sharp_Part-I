using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem7.CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main()
        {
            // Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Calculate n! / (k! * (n-k)!)";

            Console.WriteLine("Enter n and k so that 1 < k < n < 100 : ");
            Console.Write("Enter value for n: ");
            int n = int.Parse(Console.ReadLine());

            // Проверка дали "n" е в диапазона 1 < n < 100
            while ((n < 1) || (n > 100))
            {
                Console.Write("Error!!!Get yourself some glasses...");
                Console.Write("Re-enter the value for n : ");
                n = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter value for k: ");
            int k = int.Parse(Console.ReadLine());

            // Проверка дали "k" е по-голямо от "n", или  "k" е по-малко от 1
            while ((n <= k) || (k < 1))
            {
                Console.Write("Error!!!Get yourself some glasses...");
                Console.Write("Re-enter the value for k or start over: ");
                k = int.Parse(Console.ReadLine());
            }

            // Оптимизация на принципа на алгоритъма в Problem6.CalculateFactorialDivision(ред 56) в този сълюшън
            BigInteger tempResult = 1;
            for (int i = n; i > k; i--)
            {
                tempResult *= i;
            }

            // След като сме оптимизирали,т.е. сме спестили писането на още един цикъл,остава да сметнем (n-k)!
            BigInteger tempResult1 = 1;
            for (int i = (n - k); i > 1; i--)
            {
                tempResult1 *= i;
            }

            // Ето и крайният резултат
            BigInteger result = tempResult / tempResult1;

            Console.WriteLine(result);

            // Отмества "Press any key to continue..." надолу от крайният резултат
            Console.WriteLine();

        }
    }
}
