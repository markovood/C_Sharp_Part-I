using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem8.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            // In combinatorics, the Catalan numbers are calculated by the following formula --> (2n)! / (n+1)!*n!
            // Write a program to calculate the n-th Catalan number by given n (0 <= n <= 100).

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Check the next Catalan number!");
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            // Проверка на условието 0 <= n <= 100
            while ((n < 0) || (n > 100))
            {
                Console.WriteLine("Error!");
                Console.WriteLine("Check your entry!");
                Console.Write("Enter new value for n: ");
                n = int.Parse(Console.ReadLine());
            }

            // Използваме BigInteger за да си гарантираме правилни изчисления при по-големите числа (например от 15 до 100 понеже "n" може да е в обхват от 0 до 100)
            // Оптимизираме на принципа на алгоритъма от Problem6.CalculateFactorialDivision (ред 56)
            BigInteger factorialChislitel = 1;
            for (int i = 2*n; i > n; i--)
            {
                factorialChislitel *= i;
            }

            // Изчисляваме факториел в знаменателя,по-точно това което е останало от него след оптимизацията
            BigInteger factorialZnamenatel = 1;
            for (int i = n+1; i > 1; i--)
            {
                factorialZnamenatel *= i;
            }

            BigInteger nextCatalanNumber = factorialChislitel / factorialZnamenatel;
            Console.WriteLine(nextCatalanNumber);
        }
    }
}
