using System;
using System.Globalization;
using System.Threading;

namespace Problem9.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            // Write a program that reads from the console a positive integer number n (1 <= n <= 20) and prints a matrix like in the examples. 
            // Use two nested loops.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter positive integer: ");
            int n = int.Parse(Console.ReadLine());

            // Проверка на условието 1 <= n <= 20
            while ((n < 1) || (n > 20 ))
            {
                Console.Write("Error!");
                Console.Write("Re-enter a positive integer: ");
                n = int.Parse(Console.ReadLine());
            }

            // "i" ще представя редовете,а "j" колоните.На всеки ред ще се принтира сбора на реда и колоната(така се гарантира,че новият ред ще започва виинаги от числото,
            // което е следващо на първото число от предходният ред и ще завърщва на число колкото последното от предходният ред + 1) 
            // докато се стигне въведения от потребителя брой.
            // Тогава ще се минава на нов ред и ще се продължава от следващото по ред число получено от сбора на реда и колоната.
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2}",i+j);
                }
                Console.WriteLine();
            }

            // Отмества "Press any key to continue..." надолу от крайният резултат
            Console.WriteLine();
        }
    }
}
