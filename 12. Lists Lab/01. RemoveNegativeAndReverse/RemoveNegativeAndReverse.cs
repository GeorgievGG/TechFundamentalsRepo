using System;
using System.Collections.Generic;

namespace _01.RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        public static void Main()
        {
            List<double> numbers = new List<double>();
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i]) >= 0)
                {
                    numbers.Add(int.Parse(input[i]));
                }
            }
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.Write("empty");
            }
            foreach (var number in numbers)
            {

                Console.Write(number + " ");
            }
        }
    }
}
