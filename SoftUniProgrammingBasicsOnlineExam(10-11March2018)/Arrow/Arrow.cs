using System;

namespace Arrow
{
    public class Arrow
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fullWidth = n + 5;

            // top
            int numbOfUnderScores = (fullWidth - 1) / 2;
            Console.WriteLine("{0}^{0}",
                new string('_', numbOfUnderScores));
            Console.WriteLine(@"{0}/|\{0}",
                new string('_', --numbOfUnderScores));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(@"{0}/{1}|||{1}\{0}",
                    new string('_', --numbOfUnderScores),
                    new string('.', i));
            }

            int underScores = (fullWidth - 9) / 2;
            Console.WriteLine(@"{0}/..|||..\{0}",
                new string('_', underScores));
            underScores = (fullWidth - 7) / 2;
            Console.WriteLine(@"{0}/.|||.\{0}",
                new string('_', underScores));

            // body
            int bodyUnderScores = (fullWidth - 3) / 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}|||{0}",
                    new string('_', bodyUnderScores));
            }

            Console.WriteLine("{0}~~~{0}",
                new string('_', bodyUnderScores));

            // bottom
            int bottomUnderScores = n / 2;
            for (int i = 0; i < n / 2; i++)
            {
                int dots = i;
                Console.WriteLine(@"{0}//{1}!{1}\\{0}",
                    new string('_', bottomUnderScores),
                    new string('.', dots));
                bottomUnderScores--;
            }
        }
    }
}
