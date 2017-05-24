using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.FootballLeague
{
    public class FootballLeague
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var results = Console.ReadLine();
            var standings = new Dictionary<string, int>();
            var goalsScored = new Dictionary<string, int>();
            var teamRegex = new Regex(Regex.Escape(key) + @"([a-zA-Z]*)" + Regex.Escape(key));
            var scoreRegex = new Regex(@"[0-9]+:[0-9]+");
            var place = 1;
            while (results != "final")
            {
                var team1 = teamRegex.Matches(results).Cast<Match>().Select(x => x.Groups[1].Value).ToArray()[0].ToUpper();
                var team2 = teamRegex.Matches(results).Cast<Match>().Select(x => x.Groups[1].Value).ToArray()[1].ToUpper();
                var result = scoreRegex.Match(results).Value.Split(':').Select(int.Parse).ToArray();
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