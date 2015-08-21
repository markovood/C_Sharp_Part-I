using System;
using System.Globalization;
using System.Threading;

namespace Problem15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            // Using loops write a program that converts a hexadecimal integer number to its decimal form.
            // The input is entered as string. The output should be a variable of type long.
            // Do not use the built-in .NET functionality.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Hexadecimal To Decimal Converter";

            // Hexadecimal To Decimal Algorithm --> http://markovood.eu/images/HexadecimalToDecimalAlgorithm.png 
            Console.Write("Enter a HEX-number: ");
            string hex = Console.ReadLine();

            string[] temp = new string[hex.Length];

            long decimalNumber = 0;

            // Вземаме въведеното число и го разбиваме на части като всеки символ е отделен елемент от масив

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = hex[i].ToString();

                // Проверяваме всеки елемент дали съдържа буква от разрешените букви за шестнайсетичната бройна система 
                // и ако е така тази буква се замества с цифри
                switch (temp[i])
                {
                    case "a":
                    case "A":
                        temp[i] = "10";
                        break;
                    case "b":
                    case "B":
                        temp[i] = "11";
                        break;
                    case "c":
                    case "C":
                        temp[i] = "12";
                        break;
                    case "d":
                    case "D":
                        temp[i] = "13";
                        break;
                    case "e":
                    case "E":
                        temp[i] = "14";
                        break;
                    case "f":
                    case "F":
                        temp[i] = "15";
                        break;
                    default:
                        // TODO: use try/catch construction to handle exception thrown when input is wrong (not in hex) 
                        break;
                }
            }

            // Минаваме по всички елементи на масива, като ги прехвърляме към цели числа. 
            // Умножаваме ги по 16 на степен позицията,която заема в 16-чна бр. с-ма, като започваме от най-високата, тъй като тя е равноотдалечена на позицията в масива
            // виж http://markovood.eu/images/BinaryToDecimalAlgorithm.png то е съизмеримо с нашият случай
            // Накрая прибавяме получения резултат от умножението към променливата в която пазим крайният резултат

            for (int i = 0; i < temp.Length; i++)
            {
                decimalNumber += int.Parse(temp[i]) * (long)(Math.Pow(16, ((temp.Length - 1) - i)));
            }

            // Отпечатваме крайният резултат
            Console.WriteLine("The decimal equivalent is: {0}",decimalNumber);
        }
    }
}
