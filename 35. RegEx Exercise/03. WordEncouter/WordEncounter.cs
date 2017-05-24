using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.WordEncounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            var filter = Console.ReadLine();
            var sentence = Console.ReadLine();
            var sentenceCheck = @"^[A-Z].*[.!?]$";
            var filterPattern = new StringBuilder();
            filterPattern.Append(@"[a-zA-Z]*");
            //var counter = 0;
            for (int i = 1; i <= int.Parse(filter[1].ToString()); i++)
            {
                filterPattern.Append(@"[" + filter[0] + "]{1}[A-Za-z]*");
            }
            var wordsList = new List<string>();
            while (sentence != "end")
            {
                var isValidSentence = Regex.IsMatch(sentence, sentenceCheck);
                if (isValidSentence)
                {
                    var currentWords = Regex.Matches(sentence, @"\w*\w").Cast<Match>().Select(x => x.Value).ToArray();
                    foreach (var word in currentWords)
                    {
                        var match = Regex.Match(word, filterPattern.ToString());
                        if (match.Success)
                        {
                            wordsList.Add(match.Value);
                        }
                        //foreach (var ch in word)
                        //{
                        //    if (ch == filter[0])
                        //    {
                        //        counter++;
                        //    }
                        //    if (counter >= int.Parse(filter[1].ToString()))
                        //    {
                        //        wordsList.Add(word);
                        //        break;
                        //    }
                        //}
                        //counter = 0;
                    }
                }
                sentence = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", wordsList));
        }
    }
}
