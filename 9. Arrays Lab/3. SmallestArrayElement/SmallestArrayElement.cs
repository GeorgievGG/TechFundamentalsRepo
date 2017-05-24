using System;

namespace _03.SmallestArrayElement
{
    class SmallestArrayElement
    {
        public static void Main()
        {
            string[] arrayString = Console.ReadLine().Split(' ');
            int[] numbers = new int[arrayString.Length];
            int smallest = int.MaxValue;
            for (int i = 0; i < arrayString.Length; i++)
            {
                numbers[i] = int.Parse(arrayString[i]);
            }
            foreach (var num in numbers)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
