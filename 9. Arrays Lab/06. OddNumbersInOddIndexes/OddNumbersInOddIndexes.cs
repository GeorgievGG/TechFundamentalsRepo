using System;

namespace _06.OddNumbersInOddIndexes
{
    class OddNumbersInOddIndexes
    {
        public static void Main()
        {
            string[] arrayString = Console.ReadLine().Split(' ');
            int[] numbers = new int[arrayString.Length];
            for (int i = 0; i < arrayString.Length; i++)
            {
                numbers[i] = int.Parse(arrayString[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }
        }
    }
}
