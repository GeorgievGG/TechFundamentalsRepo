using System;
using System.Collections.Generic;

namespace _03.SumAdjEqualNums
{
    public class SumAdjEqualNums
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> numbers = FillNumbers(input);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                bool incomingNumberIsEqual = numbers[i] == numbers[i + 1];
                if (incomingNumberIsEqual)
                {
                    SummarizeNumbers(numbers, i);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<double> FillNumbers(string[] input)
        {
            List<double> numbers = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(double.Parse(input[i]));
            }

            return numbers;
        }

        private static void SummarizeNumbers(List<double> numbers, int i)
        {
            AddNewNumber(numbers, i);
            numbers.RemoveAt(i + 1);
            numbers.RemoveAt(i + 1);
        }

        private static void AddNewNumber(List<double> numbers, int i)
        {
            numbers.Insert(i, numbers[i] + numbers[i + 1]);
        }
    }
}
