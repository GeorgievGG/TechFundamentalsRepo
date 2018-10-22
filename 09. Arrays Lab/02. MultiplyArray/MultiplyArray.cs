using System;

namespace _02.MultiplyArray
{
    public class MultiplyArray
    {
        public static void Main()
        {
            string[] arrayInput = Console.ReadLine().Split(' ');
            double multiplier = double.Parse(Console.ReadLine());
            double[] numbers = FillNumbers(arrayInput);
            PrintResults(multiplier, numbers);
        }

        private static double[] FillNumbers(string[] arrayString)
        {
            double[] numbers = new double[arrayString.Length];
            for (int i = 0; i < arrayString.Length; i++)
            {
                numbers[i] = double.Parse(arrayString[i]);
            }

            return numbers;
        }

        private static void PrintResults(double multiplier, double[] numbers)
        {
            double result = 0;
            foreach (var num in numbers)
            {
                result = num * multiplier;
                Console.Write($"{result} ");
            }
        }
    }
}
