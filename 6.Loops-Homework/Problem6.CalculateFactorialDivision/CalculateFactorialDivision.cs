using System;
using System.Globalization;
using System.Threading;
using System.Numerics;

namespace Problem6.CalculateFactorialDivision
{
    class CalculateFactorialDivision
    {
        static void Main()
        {
            // Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            // Use only one loop.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            Console.Title = " N! / K! = ? ";

            Console.WriteLine("Calculate n! / k! for given n and k (1 < k < n < 100).");
            Console.WriteLine();

            // Ще използваме "BigInteger" понеже въпреки оптимизацията по-долу ако имаме 100! да се раздели на 10! (което е ОК по условие) се получава доста голямо число
            // което не се побира в никой от познатите ни до сега типове и резултатите ще са некоректни... 
            Console.Write("Enter value for n: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.Write("Enter value for k: ");
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            // Проверка дали 1 <  n < 100
            if ((n < 1) && (n > 100))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error!\nRe-enter value for n: ");
                n = BigInteger.Parse(Console.ReadLine());
                Console.ResetColor();
            }
            // Проверка дали 1 <  k < 100
            if ((n < 1) && (n > 100))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error!\nRe-enter value for k: ");
                k = BigInteger.Parse(Console.ReadLine());
                Console.ResetColor();
            }
            // Проверка дали n > k
            if (n < k)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error!\nn must be greater than k : ");
                n = BigInteger.Parse(Console.ReadLine());
                Console.ResetColor();
            }

            // Ако имаме 5! / 3! трябва да изчислим (1*2*3*4*5)/(1*2*3), но 1*2*3 се явява и в числителя и в знаменателя, резултата ще е 1. 
            // Така,че трябва да сметнем само 4*5.
            // Ето и оптимизирания вариант:
            BigInteger result = 1;
            for (BigInteger i = n; i > k; i--)
            {
                result *= i;
            }

            // Изчиства конзолата и форматира и отпечатва резултата
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result: {0}! / {1}! = {2}", n, k, result);
            Console.ResetColor();


            // Отмества "Press any key to continue..." надолу от крайният резултат
            Console.WriteLine("\n");
        }
    }
}
