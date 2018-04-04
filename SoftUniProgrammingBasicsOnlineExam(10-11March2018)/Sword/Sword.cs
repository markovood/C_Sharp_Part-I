using System;

namespace Sword
{
    public class Sword
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int currentN = n - 1;
            int width = (2 * n) - 1;
            int fullWidth = (2 * n) + 1;
            int middle = fullWidth / 2;


            Console.WriteLine(@"{0}/^\{0}", new string('#', currentN--));
            for (int i = 0; i < n / 2; i++)
            {
                int spaces = fullWidth - ((currentN * 2) + 2);
                Console.WriteLine("{0}.{1}.{0}", new string('#', currentN), new string(' ', spaces));
                currentN--;
            }

            int numOfHashtag = ++currentN * 2;
            int numbOfSpaces = (fullWidth - (numOfHashtag + 3)) / 2;
            Console.WriteLine("{0}|{1}S{1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));
            Console.WriteLine("{0}|{1}O{1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));
            Console.WriteLine("{0}|{1}F{1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));
            Console.WriteLine("{0}|{1}T{1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));

            for (int i = 0; i < n - 4; i++)
            {
                Console.WriteLine("{0}|{1} {1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));
            }

            Console.WriteLine("{0}|{1}U{1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));
            Console.WriteLine("{0}|{1}N{1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));
            Console.WriteLine("{0}|{1}I{1}|{0}", new string('#', currentN), new string(' ', numbOfSpaces));

            Console.WriteLine("@{0}@", new string('=', width));

            int handleNumSpaces = fullWidth - ((((n + 3) / 2) * 2) + 2);
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('#', ((n + 3) / 2)), new string(' ', handleNumSpaces));
            }

            Console.WriteLine(@"{0}\{1}/{0}", new string('#', ((n + 3) / 2)), new string('.', handleNumSpaces));
        }
    }
}
