using System;
class DeclareVariables
{
    static void Main()
    {
        // Declare five variables choosing for each of them the most appropriate of the types:
        // sbyte, byte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000

        short shortNum = -10000;
        sbyte sbyteNum = -115;
        byte byteNum = 97;
        ushort ushortNum = 52130;
        uint uintNum = 4825932; // or int intNum = 4825932;

        Console.WriteLine("short --> {0}\nsbyte --> {1}\nbyte --> {2}\nushort --> {3}\nuint --> {4}\n", shortNum, sbyteNum, byteNum, ushortNum, uintNum);        
    }
}
