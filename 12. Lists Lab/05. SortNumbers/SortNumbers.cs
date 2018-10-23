using System;
using System.Collections.Generic;

namespace _05.SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<decimal> numbers = FillNumbers(input);
            numbers.Sort();
            PrintNumbers(numbers);
        }

        private static List<decimal> FillNumbers(string[] input)
        {
            List<decimal> numbers = new List<decimal>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(decimal.Parse(input[i]));
            }

            return numbers;
        }

        private static void PrintNumbers(List<decimal> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != numbers.Count - 1)
                {
                    Console.Write(numbers[i] + " <= ");
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
