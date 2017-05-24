using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LambadaExpressions
{
    public class LambadaExpressions
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var lambdaDict = new Dictionary<string, Dictionary<string, string>>();
            while (input != "lambada")
            {
                var inputLine = input.Split(new char[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0] == "dance")
                {
                    lambdaDict = lambdaDict.ToDictionary(sel => sel.Key, sel => sel.Value.ToDictionary(so => so.Key, so => so.Key + '.' + so.Value));
                    input = Console.ReadLine();
                    continue;
                }
                var selector = inputLine[0];
                var selectorObject = inputLine[1];
                var property = inputLine[2];
                if (!lambdaDict.ContainsKey(selector))
                {
                    lambdaDict.Add(selector, new Dictionary<string, string>());
                }
                lambdaDict[selector][selectorObject] = property;
                input = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var kvp in lambdaDict)
            {
                lambdaDict[kvp.Key].ToList().ForEach(x => Console.WriteLine($"{kvp.Key} => {x.Key}.{x.Value}"));
            }
        }
    }
}
