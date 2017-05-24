using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stringParts = input.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToUpper()).ToArray();
            var numRegex = new Regex(@"[0-9]+");
            var numbers = numRegex.Matches(input).Cast<Match>().Select(x => int.Parse(x.Value)).ToArray();
            var output = new StringBuilder();
            var allSymbols = new SortedSet<char>();
            for (int i = 0; i < stringParts.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    for (int j = 0; j < numbers[i]; j++)
                    {
                        output.Append(stringParts[i]);
                    }
                    for (int k = 0; k < stringParts[i].Length; k++)
                    {
                        allSymbols.Add(stringParts[i][k]);
                    }
                }
            }
            Console.WriteLine($"Unique symbols used: {allSymbols.Count}");
            Console.WriteLine(output);
        }
    }
}
