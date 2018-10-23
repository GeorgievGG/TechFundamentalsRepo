using System;

namespace _01.LargestArrayElement
{
    public class LargestArrayElement
    {
        public static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = FillNumbers(arrayLength);
            int largest = GetLargestValue(numbers);
            Console.WriteLine(largest);
        }

        private static int[] FillNumbers(int arrayLength)
        {
            int[] numbers = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

        private static int GetLargestValue(int[] numbers)
        {
            int largest = int.MinValue;
            foreach (var num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }
    }
}
