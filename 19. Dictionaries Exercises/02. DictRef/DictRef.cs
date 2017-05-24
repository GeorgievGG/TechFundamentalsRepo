using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DictRef
{
    public class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var NumDictionary = new Dictionary<string, int>();
            bool isNumber = false;
            int number;
            while (input[0] != "end")
            {
                if (NumDictionary.ContainsKey(input[0]))
                {
                    isNumber = int.TryParse(input[1], out number);
                    if (isNumber)
                    {
                        NumDictionary[input[0]] = int.Parse(input[1]);
                    }
                    else if (!isNumber && NumDictionary.ContainsKey(input[1]))
                    {
                        NumDictionary[input[0]] = NumDictionary[input[1]];
                    }
                }
                else
                {
                    isNumber = int.TryParse(input[1], out number);
                    if (isNumber)
                    {
                        NumDictionary[input[0]] = int.Parse(input[1]);
                    }
                    else if (!isNumber && NumDictionary.ContainsKey(input[1]))
                    {
                        NumDictionary.Add(input[0], NumDictionary[input[1]]);
                    }
                }
                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var kvp in NumDictionary)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
