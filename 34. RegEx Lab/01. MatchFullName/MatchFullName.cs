using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var matched = regex.Matches(input);
            foreach (Match name in matched)
            {
                Console.WriteLine(name);
            }
        }
    }
}
