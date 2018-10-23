using System;
using System.Collections.Generic;

namespace _07.CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> numbers = FillNumbers(input);
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                int countOccurances = GetOccurancesCount(numbers, i);
                double currentNumber = numbers[i];
                PrintStatistics(countOccurances, currentNumber);

                i += countOccurances - 1;
            }
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

        private static int GetOccurancesCount(List<double> numbers, int i)
        {
            int countOccurances = 0;
            for (int j = i; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    countOccurances++;
                }
            }

            return countOccurances;
        }

        private static void PrintStatistics(int countOccurances, double currentNumber)
        {
            Console.WriteLine($"{currentNumber} -> {countOccurances}");
        }
    }
}
