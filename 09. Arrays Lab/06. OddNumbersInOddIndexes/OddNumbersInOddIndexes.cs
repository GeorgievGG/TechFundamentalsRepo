using System;

namespace _06.OddNumbersInOddIndexes
{
    public class OddNumbersInOddIndexes
    {
        public static void Main()
        {
            string[] arrayInput = Console.ReadLine().Split(' ');
            int[] numbers = FillNumbers(arrayInput);
            PrintArray(numbers);
        }

        private static int[] FillNumbers(string[] arrayInput)
        {
            int[] numbers = new int[arrayInput.Length];
            for (int i = 0; i < arrayInput.Length; i++)
            {
                numbers[i] = int.Parse(arrayInput[i]);
            }

            return numbers;
        }

        private static void PrintArray(int[] numbers)
        {
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
