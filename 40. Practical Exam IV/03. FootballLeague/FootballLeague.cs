using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.FootballLeague
{
    public class FootballLeague
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());
            var results = Console.ReadLine();
            var standings = new Dictionary<string, int>();
            var goalsScored = new Dictionary<string, int>();
            //"Regex.Escape(key) + @"([a-zA-Z]*)" + Regex.Escape(key)
            var teamRegex = new Regex($@"^.*?{key}([a-zA-Z]*){key}.*?{key}([a-zA-Z]*){key}.*?([0-9]+:[0-9]+).*$");
            var place = 1;
            while (results != "final")
            {
                if (teamRegex.IsMatch(results))
                {
                    var team1 = teamRegex.Match(results).Groups[1].Value.ToUpper();
                    var team2 = teamRegex.Match(results).Groups[2].Value.ToUpper();//.Cast<Match>().Select(x => x.Groups[1].Value).ToArray()[1].ToUpper();
                    var result = teamRegex.Match(results).Groups[3].Value.Split(':').Select(int.Parse).ToArray();
                    var reversedTeam1 = string.Join("", team1.Reverse());
                    var reversedTeam2 = string.Join("", team2.Reverse());
                    if (standings.ContainsKey(reversedTeam1))
                    {
                        goalsScored[reversedTeam1] += result[0];
                    }
                    else
                    {
                        goalsScored[reversedTeam1] = result[0];
                        standings[reversedTeam1] = 0;
                    }
                    if (standings.ContainsKey(reversedTeam2))
                    {
                        goalsScored[reversedTeam2] += result[1];
                    }
                    else
                    {
                        goalsScored[reversedTeam2] = result[1];
                        standings[reversedTeam2] = 0;
                    }
                    if (result[0] > result[1])
                    {
                        standings[reversedTeam1] += 3;
                    }
                    else if (result[0] < result[1])
                    {
                        standings[reversedTeam2] += 3;
                    }
                    else
                    {
                        standings[reversedTeam1] += 1;
                        standings[reversedTeam2] += 1;
                    }
                }
                else
                {
                    results = Console.ReadLine();
                    continue;
                }
                results = Console.ReadLine();
            }
            Console.WriteLine("League standings:");
            foreach (var team in standings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
                place++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in goalsScored.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($" - {team.Key} -> {team.Value}");
            }
        }
    }
}
