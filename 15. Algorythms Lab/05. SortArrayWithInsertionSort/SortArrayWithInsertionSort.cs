using System;
using System.Linq;

namespace _05.SortArrayWithInsertionSort
{
    public class SortArrayWithInsertionSort
    {
        public static void Main()
        {
            var integerArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < integerArray.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    SwapValues(integerArray, j);
                }
            }
            Console.WriteLine(/*"remaining: " + */string.Join(" ", integerArray));
        }

        private static void SwapValues(int[] integerArray, int j)
        {
            if (integerArray[j + 1] < integerArray[j])
            {
                integerArray[j] += integerArray[j + 1];
                integerArray[j + 1] = integerArray[j] - integerArray[j + 1];
                integerArray[j] = integerArray[j] - integerArray[j + 1];
            }
        }
    }
}
