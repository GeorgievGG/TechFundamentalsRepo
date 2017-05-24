using System;
using System.Text.RegularExpressions;

namespace _01.MatchPhoneNum
{
    class MatchPhoneNum
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b");
            var matched = regex.Matches(input);
            foreach (Match number in matched)
            {
                Console.WriteLine(number);
            }
        }
    }
}
