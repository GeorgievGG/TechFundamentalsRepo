using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DefaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var ValuesDict = new Dictionary<string, string>();
            while (input != "end")
            {
                var inputList = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (ValuesDict.ContainsKey(inputList[0]))
                {
                    ValuesDict[inputList[0]] = inputList[1];
                }
                else
                {
                    ValuesDict.Add(inputList[0], inputList[1]);
                }
                input = Console.ReadLine();
            }
            var UnchangedValues = new Dictionary<string, string>();
            var ChangedValues = new Dictionary<string, Dictionary<string, int>>();
            var defaultValue = Console.ReadLine();
            var i = 0;
            foreach (var value in ValuesDict)
            {
                if (value.Value == "null")
                {
                    ChangedValues.Add(value.Key, new Dictionary<string, int>());
                    ChangedValues[value.Key].Add(defaultValue, i);
                    i++;
                }   
                else
                {
                    UnchangedValues.Add(value.Key, value.Value);
                }
            }
            var UnhangedValuesNew = UnchangedValues.OrderByDescending(val => val.Value.Length);
            var ChangedValuesNew = ChangedValues.OrderBy(val => val.Value.Values.Single());
            foreach (var value in UnhangedValuesNew)
            {
                Console.WriteLine($"{value.Key} <-> {value.Value}");
            }
            foreach (var value in ChangedValuesNew)
            {
                Console.WriteLine($"{value.Key} <-> {value.Value.Keys.Single()}");
            }
        }
    }
}
