using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var happyRegex = new Regex(@"[:][)]|[:][D]|[;][)]|[:][*]|[:][\]]|[;][\]]|[:][}]|[;][}]|[(][:]|[*][:]|[c][:]|[\[][:]|[\[][;]");
            //"\:\)|\:D|\;\)|\:\*|\:\]|\;\]|\:\}|\;\}|\(\:|\*\:|c\:|\[\:|\[\;"
            var sadRegex = new Regex(@"[:][(]|[D][:]|[;][(]|[:][\[]|[;][\[]|[:][{]|[;][{]|[)][:]|[:][c]|[\]][:]|[\]][;]");
            //"\:\(|D\:|\;\(|\:\[|\;\[|\:\{|\;\{|\)\:|\:c|\]\:|\]\;"
            var happyMatches = happyRegex.Matches(input).Cast<Match>().Select(x => x.Value).Count();
            var sadMatches = sadRegex.Matches(input).Cast<Match>().Select(x => x.Value).Count();
            var happinessIndex = happyMatches / (double)sadMatches;
            var sign = string.Empty;
            if (happinessIndex >= 2)
            {
                sign = @":D";
            }
            else if (happinessIndex > 1)
            {
                sign = @":)";
            }
            else if (happinessIndex == 1)
            {
                sign = @":|";
            }
            else
            {
                sign = @":(";
            }
            Console.WriteLine($"Happiness index: {happinessIndex:F2} {sign}");
            Console.WriteLine($"[Happy count: {happyMatches}, Sad count: {sadMatches}]");
        }
    }
}
