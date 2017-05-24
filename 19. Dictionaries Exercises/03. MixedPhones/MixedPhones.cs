using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MixedPhones
{
    public class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var NumDictionary = new SortedDictionary<string, long>();
            bool isNumber = false;
            int phoneNumber;
            while (input[0] != "Over")
            {
                isNumber = int.TryParse(input[0], out phoneNumber);
                if (isNumber)
                {
                    NumDictionary.Add(input[1], long.Parse(input[0]));
                }
                else
                {
                    NumDictionary.Add(input[0], long.Parse(input[1]));
                }
                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var kvp in NumDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
