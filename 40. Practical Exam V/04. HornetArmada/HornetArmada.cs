using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.HornetArmada
{
    class HornetArmada
    {
        static void Main()
        {
            var incomingLines = int.Parse(Console.ReadLine());
            var armyRegistry = new Dictionary<string, Dictionary<string, long>>();
            var lastActivities = new Dictionary<string, long>();
            for (int i = 0; i < incomingLines; i++)
            {
                var armyInfo = Console.ReadLine().Split(new char[] { '=', '-', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var lastActivity = int.Parse(armyInfo[0]);
                var legionName = armyInfo[1];
                var soldierType = armyInfo[2];
                var soldierCount = int.Parse(armyInfo[3]);
                //registry handling
                if (!armyRegistry.ContainsKey(legionName))
                {
                    armyRegistry.Add(legionName, new Dictionary<string, long>());
                }
                if (!armyRegistry[legionName].ContainsKey(soldierType))
                {
                    armyRegistry[legionName].Add(soldierType, 0);
                }
                armyRegistry[legionName][soldierType] += soldierCount;
                //activity handling
                if (!lastActivities.ContainsKey(legionName))
                {
                    lastActivities.Add(legionName, 0);
                }
                lastActivities[legionName] = Math.Max(lastActivities[legionName], lastActivity);
            }
            var query = Console.ReadLine();
            if (query.Contains("\\"))
            {
                var queryParams = query.Split('\\');
                var maxActivity = int.Parse(queryParams[0]);
                var chosenType = queryParams[1];
                var chosenLegions = armyRegistry.Where(x => x.Value.Keys
                                                                .Contains(chosenType))
                                                                .Where(x => lastActivities[x.Key] < maxActivity)
                                                                .OrderByDescending(x => x.Value.Where(y => y.Key == chosenType).First().Value)
                                                                .ToDictionary(x => x.Key, y => y.Value);

                foreach (var legion in chosenLegions)
                {
                    Console.WriteLine($"{legion.Key} -> {legion.Value.Where(x => x.Key == chosenType).First().Value}");
                }
            }
            else
            {
                lastActivities
                    .Where(x => armyRegistry[x.Key].Keys.Contains(query))
                    .OrderByDescending(x => x.Value)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Value} : {x.Key}"));
            }
        }
    }
    //public class Legion
    //{
    //    public Legion(string legionName, int lastActivity)
    //    {
    //        this.LegionName = legionName;
    //        this.LastActivity = lastActivity;
    //    }
    //    public string LegionName { get; set; }
    //    public int LastActivity { get; set; }
    //}
}
