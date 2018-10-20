using System;

namespace _2.SignOfNumber
{
    public class SignOfNumber
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            AnalyzeAndPrintSign(num);
        }

        private static void AnalyzeAndPrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
