using System;
using System.Text.RegularExpressions;

namespace _03.ReplaceAnchorTag
{
    class ReplaceAnchorTag
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var totalInput = string.Empty;
            while (input != "end")
            {
                totalInput += ' ' + input;
                var regex = new Regex(@"<a.*?href.*?=(.*)>(.*?)<\/a>");//"(.+?)<a.*?href=(.+?)>(.+?)<\/a>(.+>)"
                var replacement = (@"[URL href=$1]$2[/URL]");//"$1[URL href=$2]$3[/URL]$4"
                var result = regex.Replace(input, replacement);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
