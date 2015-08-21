using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Problem3.CardWars
{
    class CardWars
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int N = int.Parse(Console.ReadLine());

            BigInteger currentScore1 = 0;
            BigInteger currentScore2 = 0;
            int hand1 = 0;
            int hand2 = 0;
            int gamesWonPl1 = 0;
            int gamesWonPl2 = 0;
            bool player1HasXCard = false;
            bool player2HasXCard = false;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "2":
                            hand1 += 10;
                            break;
                        case "3":
                            hand1 += 9;
                            break;
                        case "4":
                            hand1 += 8;
                            break;
                        case "5":
                            hand1 += 7;
                            break;
                        case "6":
                            hand1 += 6;
                            break;
                        case "7":
                            hand1 += 5;
                            break;
                        case "8":
                            hand1 += 4;
                            break;
                        case "9":
                            hand1 += 3;
                            break;
                        case "10":
                            hand1 += 2;
                            break;
                        case "A":
                            hand1 += 1;
                            break;
                        case "J":
                            hand1 += 11;
                            break;
                        case "Q":
                            hand1 += 12;
                            break;
                        case "K":
                            hand1 += 13;
                            break;
                        case "Z":
                            currentScore1 *= 2;
                            break;
                        case "Y":
                            currentScore1 -= 200;
                            break;
                        case "X":
                            player1HasXCard = true;
                            break;
                    }
                }

                for (int k = 0; k < 3; k++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "2":
                            hand2 += 10;
                            break;
                        case "3":
                            hand2 += 9;
                            break;
                        case "4":
                            hand2 += 8;
                            break;
                        case "5":
                            hand2 += 7;
                            break;
                        case "6":
                            hand2 += 6;
                            break;
                        case "7":
                            hand2 += 5;
                            break;
                        case "8":
                            hand2 += 4;
                            break;
                        case "9":
                            hand2 += 3;
                            break;
                        case "10":
                            hand2 += 2;
                            break;
                        case "A":
                            hand2 += 1;
                            break;
                        case "J":
                            hand2 += 11;
                            break;
                        case "Q":
                            hand2 += 12;
                            break;
                        case "K":
                            hand2 += 13;
                            break;
                        case "Z":
                            currentScore2 *= 2;
                            break;
                        case "Y":
                            currentScore2 -= 200;
                            break;
                        case "X":
                            player2HasXCard = true;
                            break;
                    }
                }

                if (hand1 > hand2)
                {
                    currentScore1 += hand1;
                    gamesWonPl1++;
                }
                else if (hand2 > hand1)
                {
                    currentScore2 += hand2;
                    gamesWonPl2++;
                }

                if (player1HasXCard && player2HasXCard)
                {
                    currentScore1 += 50;
                    currentScore2 += 50;
                    player1HasXCard = false;
                    player2HasXCard = false;
                }
                else if (player1HasXCard)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    return;
                }
                else if (player2HasXCard)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    return;
                }
                hand1 = 0;
                hand2 = 0;
            }

            if (currentScore1 > currentScore2)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", currentScore1);
                Console.WriteLine("Games won: {0}", gamesWonPl1);
            }
            else if (currentScore1 < currentScore2)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", currentScore2);
                Console.WriteLine("Games won: {0}", gamesWonPl2);
            }
            else if (currentScore1 == currentScore2)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", currentScore1);
            }
        }
    }
}
