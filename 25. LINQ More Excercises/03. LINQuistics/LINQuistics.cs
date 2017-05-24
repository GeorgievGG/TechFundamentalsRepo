using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var collections = new Dictionary<string, List<string>>();
            var digit = int.MinValue;
            while (input != "exit")
            {
                var inputLine = input.Split(new char[] { ' ', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine.Length == 1 && !int.TryParse(inputLine[0], out digit))
                {
                    if (!collections.ContainsKey(inputLine[0]))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    PrintMethods(collections, inputLine);
                }
                else if (inputLine.Length == 1 && digit > -1 && digit < 10)
                {
                    PrintTopMethods(collections, digit);
                }
                else
                {
                    var collection = inputLine[0];
                    if (!collections.ContainsKey(collection))
                    {
                        collections.Add(collection, new List<string>());
                    }
                    for (int i = 1; i < inputLine.Length; i++)
                    {
                        if (!collections[collection].Contains(inputLine[i]))
                        {
                            collections[collection].Add(inputLine[i]);
                        }
                    }
                }
                input = Console.ReadLine();
                digit = int.MinValue;
            }
            var finalCommand = Console.ReadLine().Split(' ');
            var method = finalCommand[0];
            switch (finalCommand[1])
            {
                case "all":
                    PrintContainingCollections(collections, method);
                    break;
                case "collection":
                    PrintContainingCollectionNames(collections, method);
                    break;
            }

        }

        private static void PrintContainingCollections(Dictionary<string, List<string>> collections, string method)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var collection in collections.Where(x => x.Value.Contains(method))
                                                                .OrderByDescending(y => y.Value.Count)
                                                                .ThenByDescending(y => y.Value.OrderBy(z => z.Length).FirstOrDefault().Length))
            {
                Console.WriteLine($"{collection.Key}");
                collection.Value
                    .OrderByDescending(x => x.Length)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"* {x}"));
            }
            Console.ResetColor();
        }

        private static void PrintContainingCollectionNames(Dictionary<string, List<string>> collections, string method)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            collections.Where(y => y.Value.Contains(method))
                .OrderByDescending(y => y.Value.Count)
                .ThenByDescending(y => y.Value.OrderBy(z => z.Length).FirstOrDefault().Length)
                .ToList()
                .ForEach(y => Console.WriteLine($"{y.Key}"));
            Console.ResetColor();
        }

        private static void PrintTopMethods(Dictionary<string, List<string>> collections, int digit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (collections.Count != 0)
            {
                collections
                    .OrderByDescending(x => x.Value.Count)
                    .First()
                    .Value
                    .OrderBy(x => x.Length)
                    .Take(digit)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"* {x}"));
            }
            Console.ResetColor();
        }

        private static void PrintMethods(Dictionary<string, List<string>> collections, string[] inputLine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (collections.ContainsKey(inputLine[0]))
            {
                collections[inputLine[0]]
                    .OrderByDescending(x => x.Length)
                    .ThenByDescending(x => x.Distinct().Count())
                    .ToList()
                    .ForEach(x => Console.WriteLine($"* {x}"));
            }
            Console.ResetColor();
        }
    }
}
