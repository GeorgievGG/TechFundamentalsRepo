using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            var searchInput = File.ReadAllText("../../../Resources/03. Word Count/words.txt").Split(' ');
            var text = File.ReadAllLines("../../../Resources/03. Word Count/text.txt");
            var searchResult = new Dictionary<string, int>();
            var count = 0;
            foreach (var searched in searchInput)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    var wordArray = text[i].Split(new char[] { '.', ',', '-', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in wordArray)
                    {
                        if (word.ToLower() == searched.ToLower())
                        {
                            count++;
                        }
                    }
                }
                searchResult[searched] = count;
                count = 0;
            }
            searchResult
                .OrderByDescending(x => x.Value)
                .ToList()
                .ForEach(x => File.AppendAllText("../../../Results/03. Word Count/result.txt", $"{x.Key} - {x.Value}" + Environment.NewLine));
        }
    }
}
