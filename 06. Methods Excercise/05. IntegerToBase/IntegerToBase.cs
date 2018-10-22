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

        private static string GetIntegerToBase(int number, int toBase)
        {
            string result = "";
            while (number != 0)
            {
                int baseEquivalent = number % toBase;
                result = baseEquivalent.ToString() + result;
                number = ReduceNumber(number, toBase);
            }

            return result;
        }

        private static int ReduceNumber(int number, int toBase)
        {
            return number / toBase;
        }
    }
}
