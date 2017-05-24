using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftuniKaraoke
{
    class SoftuniKaraoke
    {
        static void Main()
        {
            var contenders = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim());
            var otherInput = Console.ReadLine();
            var winners = new Dictionary<string, HashSet<string>>();
            while (otherInput != "dawn")
            {
                var inputParams = otherInput.Split(',').Select(x => x.Trim()).ToList();
                var contender = inputParams[0];
                var song = inputParams[1];
                var award = inputParams[2];

                if (contenders.Contains(contender) && songs.Contains(song))
                {
                    if (winners.ContainsKey(contender))
                    {
                        winners[contender].Add(award);
                    }
                    else
                    {
                        winners.Add(contender, new HashSet<string>() { award });
                    }
                }
                otherInput = Console.ReadLine();
            }
            winners = winners
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var winner in winners)
            {
                Console.WriteLine($"{winner.Key}: {winner.Value.Count} awards");
                winner.Value.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"--{x}"));
            }
            if (winners.Count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
