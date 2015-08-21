using System;
using System.Globalization;
using System.Threading;

namespace Problem11.NumberAsWords
{
    class NumberAsWords
    {

        // Write a program that converts a number in the range [0...999] to words, corresponding to the English pronunciation.

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please enter a number to see how it is spelled in English.");
            Console.WriteLine();
            Console.Write("Enter your choice [0-999]: ");
            int choice = int.Parse(Console.ReadLine());

            // Проверка дали въведеното число отговаря на зададените критерии [0-999]
            while (choice < 0 || choice > 999)
            {
                Console.WriteLine("Invalid choice!");
                choice = int.Parse(Console.ReadLine());
            }

            // Разбиваме числото на стотици,десетици и единици
            byte hundreds = (byte)(((choice / 10) / 10) % 10);
            byte decimals = (byte)((choice / 10) % 10);
            byte units = (byte)(choice % 10);

            // Тук ще записваме съответното число с думи
            string hundredsInWords = "";
            string decimalsInWords = "";
            string unitsInWords = "";

            // Задаваме за всяка отделна стойност на стотиците съответното произношение
            switch (hundreds)
            {
                case 1:
                    hundredsInWords = "One hundred";
                    break;
                case 2:
                    hundredsInWords = "Two hundred";
                    break;
                case 3:
                    hundredsInWords = "Three hundred";
                    break;
                case 4:
                    hundredsInWords = "Four hundred";
                    break;
                case 5:
                    hundredsInWords = "Five hundred";
                    break;
                case 6:
                    hundredsInWords = "Six hundred";
                    break;
                case 7:
                    hundredsInWords = "Seven hundred";
                    break;
                case 8:
                    hundredsInWords = "Eight hundred";
                    break;
                case 9:
                    hundredsInWords = "Nine hundred";
                    break;
                default:
                    hundredsInWords = "";
                    break;
            }

            // Задаваме за всяка отделна стойност на десетиците съответното произношение
            switch (decimals)
            {
                case 2:
                    decimalsInWords = "Twenty ";
                    break;
                case 3:
                    decimalsInWords = "Thirty ";
                    break;
                case 4:
                    decimalsInWords = "Forty ";
                    break;
                case 5:
                    decimalsInWords = "Fifty ";
                    break;
                case 6:
                    decimalsInWords = "Sixty ";
                    break;
                case 7:
                    decimalsInWords = "Seventy ";
                    break;
                case 8:
                    decimalsInWords = "Eighty ";
                    break;
                case 9:
                    decimalsInWords = "Ninety ";
                    break;
                default:
                    decimalsInWords = "";
                    break;
            }

            // Задаваме за всяка отделна стойност на единиците съответното произношение
            switch (units)
            {
                case 1:
                    unitsInWords = "One";
                    break;
                case 2:
                    unitsInWords = "Two";
                    break;
                case 3:
                    unitsInWords = "Three";
                    break;
                case 4:
                    unitsInWords = "Four";
                    break;
                case 5:
                    unitsInWords = "Five";
                    break;
                case 6:
                    unitsInWords = "Six";
                    break;
                case 7:
                    unitsInWords = "Seven";
                    break;
                case 8:
                    unitsInWords = "Eight";
                    break;
                case 9:
                    unitsInWords = "Nine";
                    break;
                default:
                    unitsInWords = "Zero";
                    break;
            }

            // Тъй като при стойност 1 на ДЕСЕТИЦИТЕ произношението се определя от стойността на ЕДИНИЦИТЕ проверяваме каква е тяхната стойност и задаваме съответното 
            // произношение,а също така зануляваме(задаваме празен стринг на) стойността на ЕДИНИЦИТЕ тъй като произношението на ДЕСЕТИЦИТЕ вече представлява и двете.
            if (decimals == 1)
            {
                switch (units)
                {
                    case 1:
                        decimalsInWords = "Eleven";
                        unitsInWords = "";
                        break;
                    case 2:
                        decimalsInWords = "Twelve";
                        unitsInWords = "";
                        break;
                    case 3:
                        decimalsInWords = "Thirteen";
                        unitsInWords = "";
                        break;
                    case 4:
                        decimalsInWords = "Fourteen";
                        unitsInWords = "";
                        break;
                    case 5:
                        decimalsInWords = "Fifteen";
                        unitsInWords = "";
                        break;
                    case 6:
                        decimalsInWords = "Sixteen";
                        unitsInWords = "";
                        break;
                    case 7:
                        decimalsInWords = "Seventeen";
                        unitsInWords = "";
                        break;
                    case 8:
                        decimalsInWords = "Eighteen";
                        unitsInWords = "";
                        break;
                    case 9:
                        decimalsInWords = "Nineteen";
                        unitsInWords = "";
                        break;
                    default:
                        decimalsInWords = "Ten";
                        unitsInWords = "";
                        break;
                }
            }

            // Форматираме крайния резултат преди да отпечатаме
            if ((hundreds != 0) && (units != 0))
            {
                hundredsInWords += " and ";
            }

            if (((hundreds != 0) || (decimals != 0)) && (units == 0))
            {
                unitsInWords = "";
            }

            if ((hundreds != 0) || (decimals != 0))
            {
                unitsInWords = unitsInWords.ToLower();
            }

            if (hundreds != 0)
            {
                decimalsInWords = decimalsInWords.ToLower();
            }

            Console.Clear();
            Console.WriteLine(choice);
            Console.WriteLine(hundredsInWords + decimalsInWords + unitsInWords);

        }
    }
}
