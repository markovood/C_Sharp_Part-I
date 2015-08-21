using System;
using System.Globalization;
using System.Threading;

namespace Problem10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            // A beer time is after 1:00 PM and before 3:00 AM.
            // Write a program that enters a time in format "hh:mm tt" (an hour in range [01...12], a minute in range [00...59] and AM / PM designator) and prints
            // beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
            // Note: You may need to learn how to parse dates and times.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please check if it's a beer time.\nEnter time in format (hh:mm AM/PM)-hours in range [01...12],minutes in range [00...59],AM or PM");
            //Console.WriteLine("");
            string userInput = Console.ReadLine();

            // Пробва да парсне въведеният час ако успее сравнява с часа по условие и съответно изписва "Beer time!" или "Non-Beer time!"
            try
            {
                // в нова променлива от тип DateTime се записва резултата от парсването
                DateTime userTime = DateTime.ParseExact(userInput, "HH:mm tt", CultureInfo.InvariantCulture);

                // тъй като променливата DateTime включва и дата по подразбиране създаваме нова променлива която включва само часа,това е TimeSpan
                // от въведеното от юзъра вземаме само часа 
                TimeSpan timeNow = userTime.TimeOfDay;

                // в променливи за час(TimeSpan) записваме дадените по условие час за начало и край
                TimeSpan beerTimeStart = new TimeSpan(13, 00, 00); // 1:00 PM
                TimeSpan beerTimeEnd = new TimeSpan(03, 00, 00);   // 3:00 AM

                if ((timeNow >= beerTimeStart) || (timeNow < beerTimeEnd))
                {
                    Console.WriteLine("Beer time!");
                }
                else
                {
                    Console.WriteLine("Non-Beer time!");
                }
            }
            // ако парсването не успее,т.е. хвърли някакъв Exception без значение какъв ще се изпише "Invalid time"
            catch (Exception)
            {
                Console.WriteLine("Invalid time");
            }
        }
    }
}
