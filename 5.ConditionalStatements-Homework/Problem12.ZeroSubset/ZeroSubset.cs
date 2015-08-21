using System;
using System.Globalization;
using System.Threading;

namespace Problem12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            // We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
            // Assume that repeating the same subset several times is not a problem.
            // Hint: you may check for zero each of the 31 subsets with 31 if statements.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            Console.WriteLine("Give me a set of 5 integer numbers and I'll show you all the subsets whose sum is 0");
            Console.WriteLine();
            Console.Write("Enter first integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer: ");
            int third = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth integer: ");
            int fourth = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth integer: ");
            int fifth = int.Parse(Console.ReadLine());

            // За повече подреденост и яснота
            Console.WriteLine("result: ".ToUpper());
            Console.WriteLine(new string('#', 80));
            // За да открием всички възможни подмножества трябва да сметнем колко са комбинациите при тези 5 числа(Това е 5!).След това трябва да вземем само тези  
            // комбинации при които няма повтарящи се елементи,т.е. трябва да открием колко са начините да подредим 5-те числа в редица така,че да няма 
            // повтарящи се елементи.
            // По условие трябва да намерим подмножествата на 5-те числа чийто сбор е 0.
            // n! / (k! * (n-k)!) --> формулата за намиране на комбинации от "к"-на брой различни участника от група с "n"-на брой различни елемента 
            // Като заместим по горната формула установяваме,че има:
            //          -- 5 КОМБИНАЦИИ да се наредят 5 числа в редица по 1 число
            //          -- 10 КОМБИНАЦИИ да се наредят 5 числа в редица по 2 числа
            //          -- 10 КОМБИНАЦИИ да се наредят 5 числа в редица по 3 числа
            //          -- 5 КОМБИНАЦИИ да се наредят 5 числа в редица по 4 числа
            //          -- 1 КОМБИНАЦИЯ да се наредят 5 числа в редица по 5 числа
            // Общ брой 31 КОМБИНАЦИИ,т.е от 120,общия брой възможни комбинации или 5! има само 31 начина да се комбинират 5 числа без да има повторение на числата(елементите от групата) 
            // Сега само трябва да сравним тези 31 начина дали са равни на 0 и ако ДА да покажем съответната/ите комбинация/и...

            // Тук ще бройм дали има комбинация чийто сбор е 0
            byte counter = 0;

            // 5-те КОМБИНАЦИИ да се наредят 5 числа в редица по 1 число сравнени с 0
            if (first == 0)
            {
                Console.WriteLine("{0} = 0", first);
                counter++;
            }
            if (second == 0)
            {
                Console.WriteLine("{0} = 0", second);
                counter++;
            }
            if (third == 0)
            {
                Console.WriteLine("{0} = 0", third);
                counter++;
            }
            if (fourth == 0)
            {
                Console.WriteLine("{0} = 0", fourth);
                counter++;
            }
            if (fifth == 0)
            {
                Console.WriteLine("{0} = 0", fifth);
                counter++;
            }

            // 10-те КОМБИНАЦИИ да се наредят 5 числа в редица по 2 числa сравнени с 0
            if (first + second == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, second);
                counter++;
            }
            if (first + third == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, third);
                counter++;
            }
            if (first + fourth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, fourth);
                counter++;
            }
            if (first + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", first, fifth);
                counter++;
            }
            if (second + third == 0)
            {
                Console.WriteLine("{0} + {1} = 0", second, third);
                counter++;
            }
            if (second + fourth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", second, fourth);
                counter++;
            }
            if (second + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", second, fifth);
                counter++;
            }
            if (third + fourth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", third, fourth);
                counter++;
            }
            if (third + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", third, fifth);
                counter++;
            }
            if (fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} = 0", fourth, fifth);
                counter++;
            }

            // 10-те КОМБИНАЦИИ да се наредят 5 числа в редица по 3 числa сравнени с 0
            if (first + second + third == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, third);
                counter++;
            }
            if (first + second + fourth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, fourth);
                counter++;
            }
            if (first + second + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, second, fifth);
                counter++;
            }
            if (first + third + fourth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, third, fourth);
                counter++;
            }
            if (first + third + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, third, fifth);
                counter++;
            }
            if (first + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", first, fourth, fifth);
                counter++;
            }
            if (second + third + fourth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", second, third, fourth);
                counter++;
            }
            if (second + third + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", second, third, fifth);
                counter++;
            }
            if (second + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", second, fourth, fifth);
                counter++;
            }
            if (third + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", third, fourth, fifth);
                counter++;
            }

            // 5-те КОМБИНАЦИИ да се наредят 5 числа в редица по 4 числa сравнени с 0
            if (first + second + third + fourth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, second, third, fourth);
                counter++;
            }
            if (first + second + third + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, second, third, fifth);
                counter++;
            }
            if (first + second + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, second, fourth, fifth);
                counter++;
            }
            if (first + third + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", first, third, fourth, fifth);
                counter++;
            }
            if (second + third + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", second, third, fourth, fifth);
                counter++;
            }

            // 1 КОМБИНАЦИЯ да се наредят 5 числа в редица по 5 числа
            if (first + second + third + fourth + fifth == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", first, second, third, fourth, fifth);
                counter++;
            }

            if (counter == 0)
            {
                Console.WriteLine("No Zero subsets...");
            }

            // За по-завършен вид
            Console.WriteLine(new string('#', 80));
        }
    }
}
