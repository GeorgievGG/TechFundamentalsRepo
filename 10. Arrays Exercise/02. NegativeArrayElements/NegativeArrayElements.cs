using System;

namespace _02.NegativeArrayElements
{
    public class NegativeArrayElements
    {
        public static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayLength];
            int countNegative = 0;
            for (int i = 0; i < arrayLength; i++)
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
