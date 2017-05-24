using System;
using System.Collections.Generic;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> numbers = new List<double>();
            int countOccurances = 0;
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(double.Parse(input[i]));
            }
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        countOccurances++;
                    }
                }
                i += countOccurances - 1;
                Console.WriteLine($"{numbers[i]} -> {countOccurances}");
                countOccurances = 0;
            }
        }
    }
}
