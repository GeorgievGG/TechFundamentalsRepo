using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WormsWorldParty
{
    //Worms World Party is a game where teams of worms fight each other with various weapons.Your task is to register the teams and the participants with their score, and sort out the teams by the total amount of their score.
    //You will receive several input lines in the following format:
    //{ wormName} -> {teamName} -> {wormScore}
    //The wormName and teamName will be strings, consisting of alphanumeric characters and spaces.
    //The wormScore will be an integer.
    //Your task is to store every team and its worms with their score. 
    //If the given worm already exists in one of the teams, you should IGNORE that line of input.
    //When you receive the command “quit” the input sequence ends. When that happens, you must order all teams and print them.
    //The teams must be ordered by total score of their worms, in descending order, and if 2 teams have the same total score, they must be ordered by average score (totalScore / wormCount) in descending order.For each team you must print its worms, ordered by descending order of their score.

    public class WormsWorldParty
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var teamRegistry = new Dictionary<string, Dictionary<string, long>>();
            while (input[0] != "quit")
            {
                if (!teamRegistry.ContainsKey(input[1]) && !(teamRegistry.Where(x => x.Value.ContainsKey(input[0])).Count() > 0))
                {
                    teamRegistry.Add(input[1], new Dictionary<string, long>());
                }
                if (!(teamRegistry.Where(x => x.Value.ContainsKey(input[0])).Count() > 0))
                {
                    teamRegistry[input[1]].Add(input[0], long.Parse(input[2]));
                }
                else
                {
                    input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    continue;
                }
                input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            }
            teamRegistry = teamRegistry.OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Count)
                .ToDictionary(x => x.Key, y => y.Value);
            var i = 0;
            foreach (var team in teamRegistry)
            {
                Console.WriteLine($"{++i}. Team: {team.Key} - {team.Value.Sum(x => x.Value)}");
                team.Value.OrderByDescending(x => x.Value).ToList().ForEach(x => Console.WriteLine($"###{x.Key} : {x.Value}"));
            }
        }
    }
}
