using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurances
{
    public class OddOccurances
    {
        public static void Main()
        {
            var inputString = Console.ReadLine().ToLower().Split(' ').ToArray();
            var StringDictionary = new Dictionary<string, int>();
            var listString = new List<string>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (StringDictionary.ContainsKey(inputString[i]))
                {
                    StringDictionary[inputString[i]]++;
                }
                else
                {
                    StringDictionary.Add(inputString[i], 1);
                }
            }
            foreach (var kvp in StringDictionary)
            {
                if (kvp.Value % 2 != 0)
                {
                    listString.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", listString));
        }
    }
}
