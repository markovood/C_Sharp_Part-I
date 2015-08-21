using System;
using System.Globalization;
using System.Threading;

namespace Problem3.MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            // Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
            // the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            // The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
            // The output is like in the examples.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // Подаваме на юзъра да определи колко дълга ще е поредицата...
            Console.Write("Please enter how long will be your sequence: ");
            int sequenceLenght = int.Parse(Console.ReadLine());

            // В зависимост от въведената дължина ще се създава нов масив с брой елементи дължината на поредицата и там ще се записват въведените от юзъра числа
            int[] userSequence = new int[sequenceLenght];
            int index = 0;

            for (int i = 1; i <= sequenceLenght; i++)
            {
                Console.Write("Enter number {0}: ", i);
                userSequence[index] = int.Parse(Console.ReadLine());
                index++;
            }

            // Minimal number --> Приемаме,че едно от въведените числа (да кажем първото) е "min", и го сравняваме с другите въведени.Което е по-малко се записва в "min"
            int min = userSequence[0];

            foreach (int userInput in userSequence)
            {
                min = Math.Min(min, userInput);
            }

            // Maximal number --> Приемаме,че едно от въведените числа (да кажем първото) е "max", и го сравняваме с другите въведени.Което е по-голямо се записва в "max"
            int max = 0;
            foreach (int userInput in userSequence)
            {
                max = Math.Max(max, userInput);
            }

            // Sum of all --> Вземаме всеки елемент на масива и го събираме с останалите
            int sum = 0;
            foreach (int userInput in userSequence)
            {
                sum += userInput;
            }

            // Average --> Сбора на всички разделен на техният брой
            double average = sum / (double)userSequence.Length;

            // Printout:
            Console.WriteLine(new string('*', 55));
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, average);

            // This is to put the "Press any key to continue..." away from the printout
            Console.WriteLine("\n");
        }
    }
}
