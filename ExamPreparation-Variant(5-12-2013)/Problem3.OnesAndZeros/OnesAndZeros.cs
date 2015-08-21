using System;
using System.Globalization;
using System.Threading;

namespace Problem3.OnesAndZeros
{
    class OnesAndZeros
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int N = int.Parse(Console.ReadLine());

            string binaryN = Convert.ToString(N, 2).PadLeft(32, '0');
            string last16Bits = "";

            for (int i = 16; i < 32; i++)
            {
                last16Bits += binaryN[i];
            }
            
            char[,] grandMatrix = new char[5, 63];
            int colSeparator = 3;
            int colBits = 0;

            foreach (char bit in last16Bits)
            {
                if (bit == '0')
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = colBits; j < colSeparator; j++)
                        {
                            grandMatrix[i, j] = '#';
                            if (((i > 0) && (i < 4)) && (j > colBits && j < colSeparator - 1))
                            {
                                grandMatrix[i, j] = '.';
                            }
                        }
                    }
                    colBits += 4;
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = colBits; j < colSeparator; j++)
                        {
                            grandMatrix[i, j] = '.';
                            if (j == colBits+1)
                            {
                                grandMatrix[i, j] = '#';
                            }
                            if (i == 4)
                            {
                                grandMatrix[i, j] = '#';
                            }
                            if ((i == 1) && (j == colBits))
                            {
                                grandMatrix[i, j] = '#';
                            }
                        }
                    }
                    colBits += 4;
                }
                // separator
                for (int i = 0; i < 5; i++)
                {
                    if (colSeparator > 62)
                    {
                        break;
                    }
                    grandMatrix[i, colSeparator] = '.';

                }
                colSeparator += 4;
            }
            
            // printer
            for (int i = 0; i < grandMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < grandMatrix.GetLength(1); j++)
                {
                    Console.Write(grandMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
