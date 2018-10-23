using System;
using System.Collections.Generic;

namespace _01.RemoveNegativeAndReverse
{
    public class RemoveNegativeAndReverse
    {
        private const string EMPTY_MESSAGE = "empty";

        public static void Main()
        {
            List<double> numbers = new List<double>();
            string[] input = Console.ReadLine().Split(' ');
            RemoveNegatives(numbers, input);
            CheckIfEmpty(numbers);
            numbers.Reverse();

            PrintNumbers(numbers);
        }

        private static void CheckIfEmpty(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                PrintEmptyMessage();
            }
        }

        private static void PrintEmptyMessage()
        {
            Console.Write(EMPTY_MESSAGE);
        }

        private static void RemoveNegatives(List<double> numbers, string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i]) >= 0)
                {
                    numbers.Add(int.Parse(input[i]));
                }
            }
        }

        private static void PrintNumbers(List<double> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
