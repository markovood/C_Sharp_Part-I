using System;
using System.Globalization;
using System.Threading;

namespace Problem3.BullsAndCows
{
    class BullsAndCows
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int secretNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            bool solution = false;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            // find bulls
                            int position1 = secretNumber / 1000;
                            int position2 = (secretNumber / 100) % 10;
                            int position3 = (secretNumber / 10) % 10;
                            int position4 = secretNumber % 10;

                            int guessPosition1 = i;
                            int guessPosition2 = j;
                            int guessPosition3 = k;
                            int guessPosition4 = l;

                            int currentBulls = 0;
                            int currentCows = 0;

                            if (guessPosition1 == position1)
                            {
                                currentBulls++;
                                guessPosition1 = -1;
                                position1 = -2;
                            }
                            if (guessPosition2 == position2)
                            {
                                currentBulls++;
                                guessPosition2 = -1;
                                position2 = -2;
                            }
                            if (guessPosition3 == position3)
                            {
                                currentBulls++;
                                guessPosition3 = -1;
                                position3 = -2;
                            }
                            if (guessPosition4 == position4)
                            {
                                currentBulls++;
                                guessPosition4 = -1;
                                position4 = -2;
                            }

                            // Find cows
                            if (guessPosition1 == position2)
                            {
                                currentCows++;
                                position2 = -2;
                            }
                            else if (guessPosition1 == position3)
                            {
                                currentCows++;
                                position3 = -2;
                            }
                            else if (guessPosition1 == position4)
                            {
                                currentCows++;
                                position4 = -2;
                            }

                            if (guessPosition2 == position1)
                            {
                                currentCows++;
                                position1 = -2;
                            }
                            else if (guessPosition2 == position3)
                            {
                                currentCows++;
                                position3 = -2;
                            }
                            else if (guessPosition2 == position4)
                            {
                                currentCows++;
                                position4 = -2;
                            }

                            if (guessPosition3 == position1)
                            {
                                currentCows++;
                                position1 = -2;
                            }
                            else if (guessPosition3 == position2)
                            {
                                currentCows++;
                                position2 = -2;
                            }
                            else if (guessPosition3 == position4)
                            {
                                currentCows++;
                                position4 = -2;
                            }

                            if (guessPosition4 == position1)
                            {
                                currentCows++;
                                position1 = -2;
                            }
                            else if (guessPosition4 == position2)
                            {
                                currentCows++;
                                position2 = -2;
                            }
                            else if (guessPosition4 == position3)
                            {
                                currentCows++;
                                position3 = -2;
                            }



                            if (currentBulls == bulls && currentCows == cows)
                            {
                                Console.Write("" + i + j + k + l + " ");
                                solution = true;
                            }
                        }
                    }
                }
            }

            if (solution == false)  // or (!solution)
            {
                Console.WriteLine("No");
            }
        }
    }
}
