using System;

namespace _02.MultiplyArray
{
    class MultiplyArray
    {
        public static void Main()
        {
            string[] arrayString = Console.ReadLine().Split(' ');
            var multiplier = double.Parse(Console.ReadLine());
            double[] numbers = new double[arrayString.Length];
            double result = 0;
            for (int i = 0; i < arrayString.Length; i++)
            {
                numbers[i] = double.Parse(arrayString[i]);
            }
            foreach (var num in numbers)
            {
                result = num * multiplier;
                Console.Write($"{result} ");
            }
        }
    }
}
