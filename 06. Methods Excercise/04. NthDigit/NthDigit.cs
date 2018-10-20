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

        private static int FindNthDigit(int number, int index)
        {
            int digit = 0;
            for (int i = 0; i < index; i++)
            {
                digit = GetLastDigit(number);
                number = RemoveLastDigit(number);
            }

            return digit;
        }

        private static int GetLastDigit(int number)
        {
            return number % 10;
        }

        private static int RemoveLastDigit(int number)
        {
            return number / 10;
        }
    }
}
