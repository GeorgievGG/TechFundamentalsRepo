using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.GUnit
{
    class GUnit
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var classesDict = new Dictionary<string, Dictionary<string, List<string>>>();
            //
            var wholeValidation = new Regex(@"^([A-Z][A-Za-z0-9]+( \| )*){3}$");
            while (input != "It's testing time!")
            {
                if (wholeValidation.IsMatch(input))
                {
                    var inputArray = input.Split('|').Select(x => x.Trim()).ToArray();
                    var classEntered = inputArray[0];
                    var methodEntered = inputArray[1];
                    var testEntered = inputArray[2];
                    if (!classesDict.ContainsKey(classEntered))
                    {
                        classesDict[classEntered] = new Dictionary<string, List<string>>();
                    }
                    if (!classesDict[classEntered].ContainsKey(methodEntered))
                    {
                        classesDict[classEntered][methodEntered] = new List<string>();
                    }
                    if (!(classesDict[classEntered][methodEntered].Contains(testEntered)))
                    {
                        classesDict[classEntered][methodEntered].Add(testEntered);
                    }
                }
                input = Console.ReadLine();
            }
            classesDict = classesDict.OrderByDescending(x => x.Value.SelectMany(y => y.Value).Count())
                .ThenBy(x => x.Value.Count)
                .ThenBy(x => x.Key, StringComparer.Ordinal)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in classesDict)
            {
                Console.WriteLine(kvp.Key + ":");
                var sortedMethods = kvp.Value.OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key, StringComparer.Ordinal);
                foreach (var kvp2 in sortedMethods)
                {
                    Console.WriteLine("##" + kvp2.Key);
                    kvp2.Value.OrderBy(x => x.Length).ThenBy(x => x, StringComparer.Ordinal).ToList().ForEach(x => Console.WriteLine($"####{x}"));
                }
            }
        }
    }
}
