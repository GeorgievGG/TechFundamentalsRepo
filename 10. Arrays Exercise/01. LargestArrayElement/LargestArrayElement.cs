using System;

namespace _01.LargestArrayElement
{
    class LargestArrayElement
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int largest = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach (var num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            Console.WriteLine(largest);
        }
    }
}
