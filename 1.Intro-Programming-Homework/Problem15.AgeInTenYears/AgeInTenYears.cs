using System;
class AgeInTenYears
{
    static void Main()
    {
        Console.Write("Enter your age here ---> ");

        string AgeInTenYears= Console.ReadLine();
        int UserInput = Convert.ToInt32(AgeInTenYears);

        Console.WriteLine("Your age in ten years will be... " + (UserInput + 10));

        //  Console.ReadKey();      //  This is to block the console closing when instructions are finished... (only when using F5 to start debugging...)
    }
}
