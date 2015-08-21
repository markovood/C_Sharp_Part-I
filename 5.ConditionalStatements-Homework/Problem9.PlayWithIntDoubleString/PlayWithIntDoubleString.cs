using System;
using System.Globalization;
using System.Threading;

namespace Problem9.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            // Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            // If the variable is int or double, the program increases it by one.
            // If the variable is a string, the program appends * at the end.
            // Print the result at the console. Use switch statement.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Console.WriteLine("Please enter an int: ");
                    int choice1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(choice1 + 1);
                    break;
                case "2": Console.WriteLine("Please enter a double: ");
                    double choice2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(choice2 + 1);
                    break;
                case "3": Console.WriteLine("Please enter a string: ");
                    string choice3 = Console.ReadLine();
                    Console.WriteLine(choice3 + "*");
                    break;
                default: Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
