using System;
using System.Globalization;
using System.Threading;

namespace Problem8.DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            // Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
            // Print “not a digit” in case of invalid input.
            // Use a switch statement.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please enter a digit to see how it is spelled in English.");
            Console.WriteLine();
            Console.Write("Enter your choice (0-9): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0": Console.WriteLine("{0} is Zero",choice);
                    break;
                case "1": Console.WriteLine("{0} is One", choice);
                    break;
                case "2": Console.WriteLine("{0} is Two", choice);
                    break;
                case "3": Console.WriteLine("{0} is Three", choice);
                    break;
                case "4": Console.WriteLine("{0} is Four", choice);
                    break;
                case "5": Console.WriteLine("{0} is Five", choice);
                    break;
                case "6": Console.WriteLine("{0} is Six", choice);
                    break;
                case "7": Console.WriteLine("{0} is Seven", choice);
                    break;
                case "8": Console.WriteLine("{0} is Eight", choice);
                    break;
                case "9": Console.WriteLine("{0} is Nine", choice);
                    break;
                default: Console.WriteLine("Not a digit");
                    break;
            }
        }
    }
}
