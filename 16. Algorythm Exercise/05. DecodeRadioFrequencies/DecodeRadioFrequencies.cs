using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DecodeRadioFrequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var result = new List<char>();
            for (int i = 0; i < input.Count; i++)
            {
                var firstNumber = input[i].Split('.').Select(int.Parse).ToList()[0];
                var lastNumber = input[i].Split('.').Select(int.Parse).ToList()[1];
                if (firstNumber != 0)
                {
                    result.Insert(i, (char)firstNumber);
                }
                if (lastNumber != 0)
                {
                    result.Insert(result.Count - i, (char)lastNumber);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
