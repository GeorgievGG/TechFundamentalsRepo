using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Letter_Repetition
{
    public class Letter_Repetition
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var NumDictionary = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (NumDictionary.ContainsKey(input[i]))
                {
                    NumDictionary[input[i]]++;
                }
                else
                {
                    NumDictionary.Add(input[i], 1);
                }
            }
            foreach (var kvp in NumDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
