using System;
class FloatOrDouble
{
    static void Main()
    {
        // Which of the following values can be assigned to a variable of type float and which to a variable of type double:
        // 34.567839023, 12.345, 8923.1234857, 3456.091

        float a = 12.345f;
        float b = 3456.091f;
        double c = 34.567839023d;
        double d = 8923.1234857d;

        Console.WriteLine("Float type:\n{0}\n{1}\n\nDouble type:\n{2}\n{3}\n",a,b,c,d);
    }
}
