using System;

namespace _05.CountOddNumbers
{
    public class CountOddNumbers
    {
        public static void Main()
        {
            string[] arrayInput = Console.ReadLine().Split(' ');
            int[] numbers = FillNumbers(arrayInput);
            int count = GetCountOfOddNumbers(numbers);
            Console.WriteLine(count);
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

        private static int GetCountOfOddNumbers(int[] numbers)
        {
            int count = 0;
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
