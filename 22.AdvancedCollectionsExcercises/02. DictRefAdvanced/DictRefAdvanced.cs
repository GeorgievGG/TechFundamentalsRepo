using System;
using System.Collections.Generic;

namespace _02.DictRefAdvanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictRef = new Dictionary<string, List<long>>();
            var parsedResult = 0L;
            while (input != "end")
            {
                var inputList = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (!long.TryParse(inputList[1], out parsedResult))
                {
                    if (dictRef.ContainsKey(inputList[1]))
                    {
                        if (!dictRef.ContainsKey(inputList[0]))
                        {
                            dictRef.Add(inputList[0], new List<long>());
                        }
                        dictRef[inputList[0]].AddRange(dictRef[inputList[1]]);
                    }
                }
                else
                {
                    if (!dictRef.ContainsKey(inputList[0]))
                    {
                        dictRef.Add(inputList[0], new List<long>());
                    }
                    for (int i = 1; i < inputList.Length; i++)
                    {
                        dictRef[inputList[0]].Add(long.Parse(inputList[i]));
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var name in dictRef)
            {
                Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");
            }
        }
    }
}
