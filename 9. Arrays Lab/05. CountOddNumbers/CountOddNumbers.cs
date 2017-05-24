using System;

namespace _05.CountOddNumbers
{
    class CountOddNumbers
    {
        public static void Main()
        {
            string[] arrayString = Console.ReadLine().Split(' ');
            int[] numbers = new int[arrayString.Length];
            int count = 0;
            for (int i = 0; i < arrayString.Length; i++)
            {
                numbers[i] = int.Parse(arrayString[i]);
            }
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
