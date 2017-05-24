using System;
using System.Numerics;

namespace _03.BigFactorial
{
    public class BigFactorial
    {
        public static void Main()
        {
            var initialNum = int.Parse(Console.ReadLine());
            BigInteger factorial = initialNum;
            for (int i = initialNum - 1; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
