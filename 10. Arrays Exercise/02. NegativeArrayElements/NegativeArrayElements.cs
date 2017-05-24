using System;

namespace _02.NegativeArrayElements
{
    class NegativeArrayElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int countNegative = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] < 0)
                {
                    countNegative++;
                }
            }
            Console.WriteLine(countNegative);
        }
    }
}
