using System;

namespace _3.ExactSum
{
    public class ExactSum
    {
        public static void Main()
        {
            int incomingLines = int.Parse(Console.ReadLine());
            decimal num = CalculateNumber(incomingLines);
            Console.WriteLine(num);
        }

        private static decimal CalculateNumber(int incomingLines)
        {
            decimal num = 0;
            for (int i = 0; i < incomingLines; i++)
            {
                num += decimal.Parse(Console.ReadLine());
            }

            return num;
        }
    }
}
