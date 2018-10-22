using System;

namespace _01.SumOfArrayElements
{
    public class SumOfArrayElements
    {
        public static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arr = FillArray(arrayLength);
            int sum = CalculateSum(arr);
            Console.WriteLine(sum);
        }

        private static int[] FillArray(int arrayLength)
        {
            int[] arr = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        private static int CalculateSum(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }

            return sum;
        }
    }
}
