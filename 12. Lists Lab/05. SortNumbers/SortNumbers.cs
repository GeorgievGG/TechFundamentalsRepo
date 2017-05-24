using System;
using System.Collections.Generic;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<decimal> numbers = new List<decimal>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(decimal.Parse(input[i]));
            }
            numbers.Sort();
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
