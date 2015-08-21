using System;
class StrAndObj
{
    static void Main()
    {
        // Declare two string variables and assign them with Hello and World.
        // Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
        // Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

        string str1 = "Hello";
        string str2 = "World";

        object obj1 = str1 + " " + str2;

        string str3 = (string)obj1;

        Console.WriteLine(str3);
    }
}
