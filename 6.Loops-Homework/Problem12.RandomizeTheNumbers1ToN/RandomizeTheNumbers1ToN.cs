using System;
using System.Globalization;
using System.Threading;

namespace Problem12.RandomizeTheNumbers1ToN
{
    class RandomizeTheNumbers1ToN
    {
        static void Main()
        {
            // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Randomize numbers from 1 to n");
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            // създаваме масив от булев тип с "default"-ни стойности (т.е. "false")
            // тъй като генерираме произволни числа за променливата "index" от 1 до 5 вкл.,няма шанс да ни се падне 0 за да достъпим най-първия индекс на масива 
            // затова го увеличаваме с 1 елемент
            bool[] isPrinted = new bool[n + 1];  

            Random randomNumberGenerator = new Random();
            int index;

            // Минаваме по всички индекси на масива "isPrinted" 
            for (int i = 0; i < n; i++)
            {
                // Генерираме произволно число от 1 до "n"
                index = randomNumberGenerator.Next(1, (n + 1));
                // Ако вече има отпечатано на тази позиция намаляме брояча на цикъла и пробваме пак докато не се уцели число което не е печатано
                if (isPrinted[index])
                {
                    i--;
                }
                // Ако ли не, значи позицията е свободна.Отпечатваме съответното число и на тази позиция даваме "true" за да се знае при следваща проверка, 
                // че там е вече печатано
                else
                {
                    Console.Write(index + " ");
                    isPrinted[index] = true;
                }

            }

            // Отмества "Press any key to continue..." надолу от крайният резултат
            Console.WriteLine();
        }
    }
}
