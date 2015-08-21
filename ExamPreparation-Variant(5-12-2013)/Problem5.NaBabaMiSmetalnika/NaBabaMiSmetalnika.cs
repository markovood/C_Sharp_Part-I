using System;
using System.Globalization;
using System.Threading;

namespace Problem5.NaBabaMiSmetalnika
{
    class NaBabaMiSmetalnika
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            byte width = byte.Parse(Console.ReadLine());

            int[] numbers = new int[8];
            for (int i = 0; i < 8; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            string[] rows = new string[numbers.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = Convert.ToString(numbers[i], 2).PadLeft(width, '0');
            }

            string[,] smetalo = new string[8, width];
            for (int row = 0; row < smetalo.GetLength(0); row++)
            {
                for (int col = 0; col < smetalo.GetLength(1); col++)
                {
                    smetalo[row, col] = (rows[row][col] - '0').ToString();
                }
            }

            string command = Console.ReadLine();
            int bitCount = 0;

            while (command != "stop")
            {
                if (command == "right")
                {
                    byte row = byte.Parse(Console.ReadLine());
                    sbyte col = sbyte.Parse(Console.ReadLine());

                    if (col < 0)
                    {
                        col = 0;
                    }

                    bitCount = 0;
                    for (int i = col; i < width; i++)
                    {
                        if (smetalo[row, i] == "1")
                        {
                            bitCount++;
                            smetalo[row, i] = "0";
                        }
                    }

                    col = (sbyte)(width - 1);
                    while (bitCount > 0)
                    {
                        smetalo[row, col] = "1";
                        col--;
                        bitCount--;
                    }
                }
                else if (command == "left")
                {
                    byte row = byte.Parse(Console.ReadLine());
                    sbyte col = sbyte.Parse(Console.ReadLine());

                    if (col > width - 1)
                    {
                        col = (sbyte)(width - 1);
                    }

                    bitCount = 0;
                    for (int i = col; i >= 0; i--)
                    {
                        if (smetalo[row, i] == "1")
                        {
                            bitCount++;
                            smetalo[row, i] = "0";
                        }
                    }

                    col = 0;
                    while (bitCount > 0)
                    {
                        smetalo[row, col] = "1";
                        col++;
                        bitCount--;
                    }
                }
                else if (command == "reset")
                {
                    byte row = 0;
                    while (row < 8)
                    {
                        bitCount = 0;
                        for (int i = 0; i < width; i++)
                        {
                            if (smetalo[row, i] == "1")
                            {
                                bitCount++;
                                smetalo[row, i] = "0";
                            }
                        }

                        for (int i = 0; i < width; i++)
                        {
                            if (i < bitCount)
                            {
                                smetalo[row, i] = "1";
                            }
                            else
                            {
                                smetalo[row, i] = "0";
                            }
                        }

                        row++;
                    }
                }

                command = Console.ReadLine();
            }
            
            long sum = 0;
            long emptyColumn = 0;

            //sums numbers from each row
            string[] smetaloBinary = new string[width];
            for (int row = 0; row < smetalo.GetLength(0); row++)
            {
                for (int col = 0; col < smetalo.GetLength(1); col++)
                {
                    smetaloBinary[row] += smetalo[row, col];
                }
                sum += Convert.ToInt64(smetaloBinary[row], 2);
            }

            // checks for empty columns
            int[] columns = new int[width];
            int index = 0;

            while (index < width)
            {
                for (int row = 0; row < 8; row++)
                {
                    columns[index] += int.Parse(smetalo[row, index]);
                }
                index++;
            }

            foreach (int column in columns)
            {
                if (column == 0)
                {
                    emptyColumn++;
                }
            }

            Console.WriteLine(sum * emptyColumn);
        }
    }
}
