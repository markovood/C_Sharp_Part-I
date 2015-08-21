using System;
using System.Globalization;
using System.Threading;

namespace Problem3.CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            // Classical play cards use the following signs to designate the card face: 
            // 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
            // Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] validCards = "2,3,4,5,6,7,8,9,10,J,Q,K,A".Split(',');


            Console.Write("Enter character to check if it is a valid card face: ");
            string userInput = Console.ReadLine();

            if (validCards[0] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[1] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[2] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[3] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[4] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[5] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[6] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[7] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[8] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[9] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[10] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[11] == userInput)
            {
                Console.WriteLine("yes");
            }

            else if (validCards[12] == userInput)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
