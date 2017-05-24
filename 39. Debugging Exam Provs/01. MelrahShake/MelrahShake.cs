using System;
using System.Text.RegularExpressions;

namespace _01.MelrahShake
{
    class MelrahShake
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string match = Console.ReadLine();

            var matchRegex = new Regex(Regex.Escape(match));
            var matchCollection = matchRegex.Matches(input);
            while (true)
            {
                if (matchCollection.Count >= 2 && match.Length > 0)
                {
                    var firstMatchIx = input.IndexOf(match);
                    var lastMatchIx = input.LastIndexOf(match);
                    input = input.Remove(lastMatchIx, match.Length);
                    input = input.Remove(firstMatchIx, match.Length);
                    match = match.Remove(match.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                matchRegex = new Regex(Regex.Escape(match));
                matchCollection = matchRegex.Matches(input);
            }
            Console.WriteLine(input);
        }
    }
}
