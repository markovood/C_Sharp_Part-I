using System;

namespace Problem6.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            // Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            // Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
            // Prints on the console the number in reversed order: dcba (in our example 1102).
            //Puts the last digit in the first position: dabc (in our example 1201).
            //Exchanges the second and the third digits: acbd (in our example 2101).
                                // NOTE:
            //The number has always exactly 4 digits and cannot start with 0.

            Console.Write("Please enter number 1-9 for position 1: ");
            byte userInputA = byte.Parse(Console.ReadLine());

            if ((userInputA == 0) || (userInputA > 9))
            {
                Console.WriteLine("Wrong entry...\nTry again... ");
            }

            else
            {
                Console.Write("Please enter a number 0-9 for position 2: ");
                byte userInputB = byte.Parse(Console.ReadLine());

                if (userInputB > 9)
                {
                    Console.WriteLine("Wrong entry...\nTry again...");
                }

                else
                {
                    Console.Write("Please enter a number 0-9 for position 3: ");
                    byte userInputC = byte.Parse(Console.ReadLine());

                    if (userInputC > 9)
                    {
                        Console.WriteLine("Wrong entry...\nTry again...");
                    }

                    else
                    {
                        Console.Write("Please enter a number 0-9 for position 4: ");
                        byte userInputD = byte.Parse(Console.ReadLine());

                        if (userInputD > 9)
                        {
                            Console.WriteLine("Wrong entry...\nTry again...");
                        }

                        else
                        {
                            string enteredNum = Convert.ToString(userInputA) + Convert.ToString(userInputB) + Convert.ToString(userInputC) + Convert.ToString(userInputD);
                            Console.WriteLine(new string('*', 45));  // Prints separator made of * for more ordered and clear output 
                            Console.WriteLine("The number you entered is: " + enteredNum);
                            int sum = userInputA + userInputB + userInputC + userInputD;
                            Console.WriteLine("The sum of the digits of your number is: " + sum);
                            Console.WriteLine("Your number in reverse order is: " + enteredNum[3] + enteredNum[2] + enteredNum[1] + enteredNum[0]);
                            Console.WriteLine("Last digit in the first position: " + enteredNum[3] + enteredNum[0] + enteredNum[1] + enteredNum[2]);
                            Console.WriteLine("Exchange the second and the third digits of your number: " + enteredNum[0] + enteredNum[2] + enteredNum[1] + enteredNum[3]);
                        }
                    }
                }
            }


        }
    }
}
