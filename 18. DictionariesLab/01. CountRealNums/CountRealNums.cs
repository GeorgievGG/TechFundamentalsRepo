using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNums
{
    public class CountRealNums
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var NumDictionary = new SortedDictionary<double, int>();
            for (int i = 0; i < inputNums.Length; i++)
            {
                if (NumDictionary.ContainsKey(inputNums[i]))
                {
                    NumDictionary[inputNums[i]]++;
                }
                else
                {
                    NumDictionary.Add(inputNums[i], 1);
                }
            }
            foreach (var kvp in NumDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
