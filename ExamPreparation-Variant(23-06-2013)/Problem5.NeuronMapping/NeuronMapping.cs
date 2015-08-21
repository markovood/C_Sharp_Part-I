using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Problem5.NeuronMapping
{
    class NeuronMapping
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            long line = long.Parse(Console.ReadLine());
            List<string> grid = new List<string>();

            while (line != -1)
            {
                grid.Add(Convert.ToString(line, 2).PadLeft(32, '0'));

                line = long.Parse(Console.ReadLine());
            }

            int count = 0;
            int position = 0;
            bool bitOne = false;
            string[] newGrid = new string[grid.Count];

            // get each line and check if there is and how many 0s there are between 1....1
            for (int row = 0; row < grid.Count; row++)
            {
                for (int i = 0; i < grid[row].Length; i++)
                {// TODO:check in bgcoder the final vesion 
                    if (grid[row][i] == '1' && i < 31)  // added && i < 31
                    {
                        if (grid[row][i + 1] == '0')
                        {
                            position = i + 1;
                            int broqch = i + 1;
                            while (broqch < 32)
                            {
                                if (grid[row][broqch] == '1')
                                {
                                    bitOne = true;
                                    break;
                                }
                                broqch++;
                                count++;
                            }

                            if (bitOne)
                            {
                                newGrid[row] += new string('0', position);
                                newGrid[row] += new string('1', count);
                                newGrid[row] += new string('0', 32 - (position + count));
                                count = 0;
                                bitOne = false;
                                break;
                            }
                            else
                            {
                                newGrid[row] = new string('0', 32);
                                count = 0;
                                break;
                            }
                        }
                    }
                }
            }

            // read each line and convert it from binary to decimal and print it
            for (int i = 0; i < newGrid.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(newGrid[i], 2));
            }
        }
    }
}
