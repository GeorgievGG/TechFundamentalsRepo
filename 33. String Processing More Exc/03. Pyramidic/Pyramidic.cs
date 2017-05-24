using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            var expectedLines = int.Parse(Console.ReadLine());
            var charsDict = new Dictionary<char, List<int>>();
            var maxPyramidLength = 0;
            var pyramidSymbol = ' ';
            for (int i = 1; i <= expectedLines; i++)
            {
                var input = Console.ReadLine();
                foreach (var ch in input.Union(charsDict.Keys).Distinct())
                {
                    var maxConsecutiveOccurances = 1;
                    var consecutiveOccurances = 1;
                    for (int j = 0; j < input.Length - 1; j++)
                    {
                        if (input[j] == ch && input[j] == input[j + 1])
                        {
                            consecutiveOccurances++;
                            if (maxConsecutiveOccurances < consecutiveOccurances)
                            {
                                maxConsecutiveOccurances = consecutiveOccurances;
                            }
                        }
                        else
                        {
                            consecutiveOccurances = 1;
                        }
                    }
                    if (!input.Contains(ch))
                    {
                        charsDict[ch].Add(0);
                        continue;
                    }
                    if (charsDict.ContainsKey(ch))
                    {
                        charsDict[ch].Add(maxConsecutiveOccurances);
                    }
                    else
                    {
                        charsDict[ch] = new List<int>() { (maxConsecutiveOccurances) };
                    }
                }
            }
            foreach (var ch in charsDict)
            {
                var pyramidLength = 1;
                for (int i = 0; i < ch.Value.Count - 1; i++)
                {
                    if (i > 0 && ch.Value[i] <= ch.Value[i - 1])
                    {
                        continue;
                    }
                    if (pyramidLength == 1)
                    {
                        ch.Value[i] = 1;
                    }
                    if (ch.Value[i] + 2 <= ch.Value[i + 1])
                    {
                        pyramidLength += 1;
                        ch.Value[i + 1] = ch.Value[i] + 2;
                    }
                    else
                    {
                        if (maxPyramidLength < pyramidLength)
                        {
                            maxPyramidLength = pyramidLength;
                            pyramidSymbol = ch.Key;
                        }
                        pyramidLength = 1;
                    }
                }
                if (maxPyramidLength < pyramidLength)
                {
                    maxPyramidLength = pyramidLength;
                    pyramidSymbol = ch.Key;
                }
                pyramidLength = 0;
            }
            for (int i = 1; i <= maxPyramidLength; i++)
            {
                Console.WriteLine(new String(pyramidSymbol, 2 * i - 1));
            }
        }
    }
}
