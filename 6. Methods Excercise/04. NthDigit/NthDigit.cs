using System;

namespace _04.NthDigit
{
    public class NthDigit
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }
        static int FindNthDigit(int number, int index)
        {
            int digit = 0;
            for (int i = 0; i < index; i++)
            {
                digit = number % 10;
                number /= 10;
            }
            return digit;
        }
    }
}
