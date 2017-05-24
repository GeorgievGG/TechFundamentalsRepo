using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var shells = new Dictionary<string, List<long>>();
            while (input != "Aggregate")
            {
                var inputList = input.Split(' ');
                if (!shells.ContainsKey(inputList[0]))
                {
                    shells.Add(inputList[0], new List<long>());
                }
                if (!shells[inputList[0]].Contains(long.Parse(inputList[1])))
                {
                    shells[inputList[0]].Add(long.Parse(inputList[1]));
                }
                input = Console.ReadLine();
            }
            foreach (var city in shells)
            {
                Console.WriteLine($"{city.Key} -> {string.Join(", ", city.Value)} ({city.Value.Sum() - city.Value.Sum() / city.Value.Count})");
            }
        }
    }
}
