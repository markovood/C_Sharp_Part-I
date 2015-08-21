using System;
using System.Globalization;
using System.Threading;

namespace Problem5.Warhead
{
    class Warhead
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            // TESTS NUMBERS 5 & 30 ARE WRONG DON'T PAY ATTENTION!!!
            string[] input = new string[16];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }

            // assigning the board with capacitors 1 extra line on top,bottom,left and right avoids the out of range exception
            int[,] board = new int[18, 18];
            int index1 = 0;
            int index2 = 0;
            for (int i = 1; i < board.GetLength(0) - 1; i++)
            {
                index2 = 0;
                for (int j = 1; j < board.GetLength(1) - 1; j++)
                {
                    board[i, j] = input[index1][index2] - '0';
                    index2++;
                }
                index1++;
            }

            // counting shapes
            int leftSideShapeCounter = 0;
            int rightSideShapeCounter = 0;
            for (int i = 1; i < board.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < board.GetLength(1) - 1; j++)
                {
                    if (board[i, j] == 0)
                    {
                        if (
                            board[i - 1, j - 1] == 1 && board[i - 1, j] == 1 && board[i - 1, j + 1] == 1 &&
                            board[i, j - 1] == 1 && board[i, j + 1] == 1 &&
                            board[i + 1, j - 1] == 1 && board[i + 1, j] == 1 && board[i + 1, j + 1] == 1
                            )
                        {
                            if (j <= 8)
                            {
                                leftSideShapeCounter++;
                            }
                            else
                            {
                                rightSideShapeCounter++;
                            }
                        }
                    }
                }
            }


            //string hoverResult = "";
            string command = Console.ReadLine();
            while (true)
            {
                if (command == "hover")
                {
                    int row = int.Parse(Console.ReadLine()) + 1;
                    int col = int.Parse(Console.ReadLine()) + 1;

                    if (board[row, col] == 1)
                    {
                        //hoverResult += '*';
                        Console.WriteLine('*');
                    }
                    else
                    {
                        //hoverResult += '-';
                        Console.WriteLine('-');
                    }
                }
                else if (command == "operate")
                {
                    int row = int.Parse(Console.ReadLine()) + 1;
                    int col = int.Parse(Console.ReadLine()) + 1;

                    if (board[row, col] == 0)
                    {
                        if (
                            board[row - 1, col - 1] == 1 &&
                            board[row - 1, col] == 1 &&
                            board[row - 1, col + 1] == 1 &&
                            board[row, col - 1] == 1 &&
                            board[row, col + 1] == 1 &&
                            board[row + 1, col - 1] == 1 &&
                            board[row + 1, col] == 1 &&
                            board[row + 1, col + 1] == 1
                           )
                        {
                            board[row - 1, col - 1] = 0;
                            board[row - 1, col] = 0;
                            board[row - 1, col + 1] = 0;
                            board[row, col - 1] = 0;
                            board[row, col + 1] = 0;
                            board[row + 1, col - 1] = 0;
                            board[row + 1, col] = 0;
                            board[row + 1, col + 1] = 0;
                            if (col <= 8)
                            {
                                leftSideShapeCounter--;
                            }
                            else
                            {
                                rightSideShapeCounter--;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("missed");
                        Console.WriteLine(leftSideShapeCounter + rightSideShapeCounter);
                        Console.WriteLine("BOOM");
                        return;
                    }
                }
                else if (command == "cut")
                {
                    string whatToCut = Console.ReadLine();
                    if (whatToCut == "red")
                    {
                        if (leftSideShapeCounter == 0)
                        {
                            Console.WriteLine(rightSideShapeCounter);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(leftSideShapeCounter);
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }
                    else if (whatToCut == "blue")
                    {
                        if (rightSideShapeCounter == 0)
                        {
                            Console.WriteLine(leftSideShapeCounter);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(rightSideShapeCounter);
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }

                }

                command = Console.ReadLine();
            }
        }
    }
}
