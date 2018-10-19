using System;

namespace _01.SumOfArrayElements
{
    class SumOfArrayElements
    {
        public static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
