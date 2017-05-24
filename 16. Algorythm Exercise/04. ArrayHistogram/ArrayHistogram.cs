using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var wordsCount = new List<int>();
            var uniqueWords = new List<string>();
            var counter = 0;
            var tempNum = 0;
            var tempStr = "";
            for (int i = 0; i < input.Count; i++)
            {
                if (!uniqueWords.Contains(input[i]))
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[i] == input[j])
                        {
                            counter++;
                        }
                    }
                    wordsCount.Add(counter);
                    uniqueWords.Add(input[i]);
                    counter = 0;
                }
            }
            var lastSortedWord = uniqueWords.Count - 1;
            while (lastSortedWord != 0)
            {
                for (int j = 0; j < lastSortedWord; j++)
                {
                    if (wordsCount[j] < wordsCount[j + 1])
                    {
                        tempNum = wordsCount[j];
                        wordsCount[j] = wordsCount[j + 1];
                        wordsCount[j + 1] = tempNum;
                        tempStr = uniqueWords[j];
                        uniqueWords[j] = uniqueWords[j + 1];
                        uniqueWords[j + 1] = tempStr;
                    }
                }
                lastSortedWord--;
            }
            for (int i = 0; i < uniqueWords.Count; i++)
            {
                Console.WriteLine($"{uniqueWords[i]} -> {wordsCount[i]} times ({((double)wordsCount[i] / input.Count * 100).ToString("N2")}%)");
            }
        }
    }
}
