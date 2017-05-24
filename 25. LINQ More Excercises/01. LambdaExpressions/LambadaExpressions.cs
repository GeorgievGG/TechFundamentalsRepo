using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LambdaExpressions
{
    class LambadaExpressions
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var lambdaDict = new Dictionary<string, Dictionary<string, string>>();
            while (input != "lambada")
            {
                var inputLine = input.Split(new char[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (input == "dance")
                {
                    //lambdaDict = lambdaDict.ToList().ForEach(x => lambdaDict[x.Key].ToDictionary(key => key.Key + '.' + key.Key, val => val.Value));
                    foreach (var key in lambdaDict.Keys.ToList())
                    {
                        lambdaDict[key] = lambdaDict[key].ToDictionary(x => x.Key + '.' + x.Key.Substring(0, Math.Abs(x.Key.IndexOf('.'))), y => y.Value);
                    }
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
