using System;
using System.Globalization;
using System.Threading;

namespace Problem4.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            // Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
            // The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            // The card faces should start from 2 to A.
            // Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
            // Note: You may use the suit symbols instead of text.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // Записваме валидните карти в масив от тип стринг заради карта "10" ,а валидните бои в масив от тип char 
            string[] cardFaces = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            char[] cardSuits = new char[4] { '\u2663', '\u2666', '\u2665', '\u2660' };

    // Вътрешният цикъл печата на един ред поредната карта във всички бои, а външният след отпечатване на всички бои добавя нов ред и занулява индекса на масива с боите
    // за да започне от началото при следващо влизане
            int index = 0;
            for (int i = 0; i < cardFaces.Length; i++)
            {
                for (int j = 0; j < cardSuits.Length; j++)
                {
                    Console.Write("{0,2}{1,-2}", cardFaces[i], cardSuits[index]);
                    index++;
                }
                Console.WriteLine();
                index = 0;
            }

            // This is to put the "Press any key to continue..." away from the printout
            Console.WriteLine("\n");
        }
    }
}
