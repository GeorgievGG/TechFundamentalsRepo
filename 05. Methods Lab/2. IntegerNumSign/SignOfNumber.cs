using System;

namespace _2.SignOfNumber
{
    class SignOfNumber
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            AnalyzeAndPrintSign(num);
        }
        static void AnalyzeAndPrintSign(int num)
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
