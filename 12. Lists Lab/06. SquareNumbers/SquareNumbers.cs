using System;
using System.Collections.Generic;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<long> numbers = new List<long>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(long.Parse(input[i]));
            }
            //numbers.Sort((a,b) => b.CompareTo(a));
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != numbers.Count - 1 && Math.Sqrt(numbers[i]) % 1 == 0)
                //if (Math.Sqrt(double.Parse(input[i])) == (int)Math.Sqrt(double.Parse(input[i])) && double.Parse(input[i]) != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
                else if (i == numbers.Count - 1 && Math.Sqrt(numbers[i]) % 1 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
