using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CottageScraper
{
    class CottageScraper
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var Logs = new Dictionary<string, List<decimal>>();
            while (input != "chop chop")
            {
                var inputList = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var treeType = inputList[0];
                var logHeight = decimal.Parse(inputList[1]);
                if (!Logs.ContainsKey(treeType))
                {
                    Logs.Add(treeType, new List<decimal>());
                }
                Logs[treeType].Add(logHeight);
                input = Console.ReadLine();
            }
            var chosenType = Console.ReadLine();
            var minLenght = decimal.Parse(Console.ReadLine());
            var allLogs = Logs.SelectMany(x => x.Value).Sum();
            var allLogsCt = Logs.SelectMany(x => x.Value).Count();
            var PricePerMeter = Math.Round(Logs.SelectMany(x => x.Value).Sum() / Logs.SelectMany(x => x.Value).Count(), 2);
            var usedLogsPrice = Math.Round(Logs[chosenType].Where(log => log >= minLenght).Sum() * PricePerMeter, 2);
            var unusedLogsPrice = Math.Round((Logs.Where(x => x.Key != chosenType).SelectMany(x => x.Value).Sum() + Logs[chosenType].Where(log => log < minLenght).Sum()) * PricePerMeter * 0.25m, 2);
            var totalPrice = usedLogsPrice + unusedLogsPrice;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Price per meter: ${PricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
        }
    }
}
