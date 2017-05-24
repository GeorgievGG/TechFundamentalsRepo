using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    class WinningTicket
    {
        static void Main()
        {
            var tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var firstHalf = ticket.Substring(0, 10);
                var secHalf = ticket.Substring(10);

                var pattern = @"([$]{6,10})|([\^]{6,10})|([#]{6,10})|([@]{6,10})";

                var firstHalfMatches = Regex.Matches(firstHalf, pattern).Cast<Match>().Select(m => m.Value).ToArray();
                var secHalfMatches = Regex.Matches(secHalf, pattern).Cast<Match>().Select(m => m.Value).ToArray();

                if (firstHalfMatches.Where(x => secHalfMatches.Select(y => y.Substring(0, 6)).Contains(x.Substring(0,6)) == true).Count() != 0)
                {
                    var doubleMatch = firstHalfMatches
                        .Where(x => secHalfMatches
                                .Select(y => y.Substring(0, 6))
                                .Contains(x.Substring(0, 6)) == true)
                        .First()
                        .ToString();
                    var otherMatch = secHalfMatches
                        .Where(x => x.Contains(doubleMatch.Substring(0, 6)))
                        .First()
                        .ToString(); ;
                    if (otherMatch.Length < doubleMatch.Length)
                    {
                        doubleMatch = otherMatch;
                    }
                    //var longestRightMatch = secHalfMatches
                    //    .Select(x => secHalfMatches.Contains(x))
                    //    .First()
                    //    .ToString();
                    //if (longestLeftMatch.Length == longestRightMatch.Length)
                    //{
                        if (doubleMatch.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {doubleMatch.Length}{doubleMatch[0]} Jackpot!");
                        }
                        else if (doubleMatch.Length >= 6)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {doubleMatch.Length}{doubleMatch[0]}");
                        }
                    //}
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
