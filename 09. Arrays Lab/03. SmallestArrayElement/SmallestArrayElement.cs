using System;

namespace _03.SmallestArrayElement
{
    public class SmallestArrayElement
    {
        public static void Main()
        {
            string[] arrayInput = Console.ReadLine().Split(' ');
            int[] numbers = FillNumbers(arrayInput);
            int smallest = GetSmallestNumber(numbers);
            Console.WriteLine(smallest);
        }

        private static int[] FillNumbers(string[] arrayString)
        {
            int[] numbers = new int[arrayString.Length];
            for (int i = 0; i < arrayString.Length; i++)
            {
                numbers[i] = int.Parse(arrayString[i]);
            }

            return numbers;
        }

        private static int GetSmallestNumber(int[] numbers)
        {
            int smallest = int.MaxValue;
            foreach (var num in numbers)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }

            return smallest;
        }
    }
}
