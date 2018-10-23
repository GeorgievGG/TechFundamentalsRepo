using System;
using System.Collections.Generic;

namespace _06.SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<long> numbers = FillNumbers(input);
            numbers.Sort();
            numbers.Reverse();
            PrintNumbers(numbers);
        }

        private static List<long> FillNumbers(string[] input)
        {
            List<long> numbers = new List<long>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(long.Parse(input[i]));
            }

            return numbers;
        }

        private static void PrintNumbers(List<long> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                bool numberIsNotInTheEnd = i != numbers.Count - 1;
                bool isSquaredNumber = Math.Sqrt(numbers[i]) % 1 == 0;
                if (numberIsNotInTheEnd && isSquaredNumber)
                {
                    Console.Write(numbers[i] + " ");
                }
                else if (!numberIsNotInTheEnd && isSquaredNumber)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
