using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjEqualNums
{
    class SumAdjEqualNums
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<double> numbers = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(double.Parse(input[i]));
            }
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers.Insert(i, numbers[i] + numbers[i + 1]);
                    numbers.RemoveAt(i + 1);
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
