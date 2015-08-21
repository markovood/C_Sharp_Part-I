using System;
using System.Globalization;
using System.Threading;

namespace Problem19.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
            // holding the numbers from 1 to n*n in the form of square spiral 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter how big your matrix will be...");
            Console.WriteLine("You are allowed --> 1 <= n <= 20");
            int n = int.Parse(Console.ReadLine());

            // Checks if the user input is positive and acceptable
            while ((n < 1) || (n > 20))
            {
                Console.WriteLine("You are allowed only --> 1 <= n <= 20");
                n = int.Parse(Console.ReadLine());
            }

            int[,] matrix = new int[n, n];

            // Clears the Console before printing the result
            Console.Clear();

            // using these variables we control completely how our program writes values in the matrix
            int row = 0;
            int col = 0;

            // here we save the next number as we start from 1
            int nextNumber = 1;

 // using a new variable just to guarantee that the rule in the while cycle will not be interrupted when we change the size of the matrix before we get out of the cycle
            int matrixArea = n * n;

            // the while cycle will repeat going right,down,left and up until the last cell of our matrix is filled up 
            while (nextNumber <= matrixArea)
            {

                // Going right
                for (int i = 0; i < n; i++)
                {
                    matrix[row, col] = nextNumber;
                    nextNumber++;
                    col++;
                }

                // Going down
                col--;
                row++;

                for (int i = 0; i < n - 1; i++)
                {
                    matrix[row, col] = nextNumber;
                    nextNumber++;
                    row++;
                }

                // Going left
                row--;
                col--;

                for (int i = 0; i < n - 1; i++)
                {
                    matrix[row, col] = nextNumber;
                    nextNumber++;
                    col--;
                }

                // Going up
                col++;
                row--;

                for (int i = 0; i < n - 2; i++)
                {
                    matrix[row, col] = nextNumber;
                    nextNumber++;
                    row--;
                }

                row++;
                col++;

                n -= 2;
            }


            // Prints the complete formatted matrix 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            // moves the "Press any key to continue..." away from the output
            Console.WriteLine("\n");
        }
    }
}
