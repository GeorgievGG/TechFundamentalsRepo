using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var ValuesDict = new Dictionary<string, Dictionary<string, string>>();
            var flattenedOrder = new Dictionary<string, int>();
            var j = 0;
            while (input != "end")
            {
                var inputList = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                j = 0;
                if (inputList[0] == "flatten")
                {
                    foreach (var kvp in ValuesDict[inputList[1]].Where(kvp => kvp.Value != null).ToList())
                    {
                        if (kvp.Value == null)
                        {
                            break;
                        }
                        ValuesDict[inputList[1]].Add(kvp.Key + kvp.Value, null);
                        flattenedOrder.Add(kvp.Key + kvp.Value, j);
                        j++;
                    }
                    foreach (var kvp in ValuesDict[inputList[1]].Where(kvp => kvp.Value != null).ToList())
                    {
                        if (kvp.Value == null)
                        {
                            break;
                        }
                        ValuesDict[inputList[1]].Remove(kvp.Key);
                    }
                    input = Console.ReadLine();
                    continue;
                }
                if (!ValuesDict.ContainsKey(inputList[0]))
                {
                    ValuesDict.Add(inputList[0], new Dictionary<string, string>());
                }
                if (!ValuesDict[inputList[0]].ContainsKey(inputList[1]))
                {
                    ValuesDict[inputList[0]].Add(inputList[1], string.Empty);
                }
                ValuesDict[inputList[0]][inputList[1]] = inputList[2];
                input = Console.ReadLine();
            }
            var orderdInnerKey = new Dictionary<string, IOrderedEnumerable<KeyValuePair<string, string>>>();
            foreach (var kvp in ValuesDict)
            {
                orderdInnerKey.Add(kvp.Key, kvp.Value.OrderBy(x => x.Key.Length));
            }
            var result = orderdInnerKey.OrderByDescending(x => x.Key.Length).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            var i = 0;
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
                foreach (var innerKVP in result[kvp.Key])
                {
                    if (innerKVP.Value != null)
                    {
                        i++;
                        Console.WriteLine($"{i}. {innerKVP.Key} - {innerKVP.Value}");
                    }
                }
                if (result[kvp.Key].ToDictionary(pair => pair.Key, pair => pair.Value).ContainsValue(null))
                {
                    foreach (var ink in flattenedOrder)
                    {
                        i++;
                        if (result[kvp.Key].ToDictionary(pair => pair.Key, pair => pair.Value).ContainsKey(ink.Key))
                        Console.WriteLine($"{i}. {ink.Key}");
                    }
                }
                i = 0;
            }
        }
    }
}

