using System;

namespace _12.HexadecimalVar
{
    public class HexadecimalVar
    {
        public static void Main()
        {
            string hexadecimalNum = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimalNum, 16));
        }
    }
}
