using System;

namespace _12.HexadecimalVar
{
    class HexadecimalVar
    {
        static void Main()
        {
            string hexadecimalNum = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimalNum, 16));
        }
    }
}
