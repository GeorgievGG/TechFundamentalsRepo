using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var serialized = new Dictionary<char, List<int>>();
            for (int i = 0; i < input.Length; i++)
            {
                if (serialized.ContainsKey(input[i]))
                {
                    serialized[input[i]].Add(i);
                }
                else
                {
                    serialized.Add(input[i], new List<int>() { i });
                }
            }
            serialized.ToList().ForEach(x => Console.WriteLine($"{x.Key}:{string.Join("/", x.Value)}"));
        }
    }
}
