using System;

namespace _05.IntegerToBase
{
    public class IntegerToBase
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(GetIntegerToBase(number, toBase));
        }
        static string GetIntegerToBase(int number, int toBase)
        {
            string result = "";
            while (number != 0)
            {
                result = (number % toBase).ToString() + result;
                number /= toBase;
            }
            return result;
        }
    }
}
