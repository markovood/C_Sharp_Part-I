using System;

namespace Problem8.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            // Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
            // Note: You should check if the number is positive

            Console.Write("Enter a number less than or equal to 100 to check if it's a prime: ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;        // Вярно до доказване на противното!

            if (n < 0 || n == 1)        // Простите числа са цели и по-големи от 0.Числата 0 и 1 не са нито прости, нито съставни(всички други).
            {
                isPrime = false;
                Console.WriteLine("Is the number you've entered prime: " + isPrime);
            }

            else
            {
                for (int divider = 2; divider <= Math.Sqrt(n); divider++)
                {
                    if (n % divider == 0)       // Тъй като числото n може да се дели на всяко число ,но за да е просто трябва да се дели само на себе си и 1,
                    {                           // затова проверяваме дали n се дели без остатък на друго число от 2 до корен кв. от n и ако е така значи n не се дели 
                        isPrime = false;        // само на себе си и 1 ,но и на друго число следователно НЕ е просто.!
                    }
                }

                Console.WriteLine("Is the number you've entered prime: " + isPrime);    // Програмата работи и за по-големи от 100 числа!!!
            }
        }
    }
}
