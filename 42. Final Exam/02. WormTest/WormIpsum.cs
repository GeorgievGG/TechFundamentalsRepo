using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.WormTest
{
    //You will receive several input lines containing sentences. They represent the random data rendered by the AI.Your task is to validate every input line and process the words inside the sentence.
    //The sentences will ALWAYS start with a capital letter and end with a dot “.”, because the AI is simple.
    //IGNORE all input lines which contain more than 1 sentence.
    //ALL sentences will be grammatically correct.
    //You must then pass through each VALID input line, and go through the words in its sentence. If you find a word which has 2 or more equal characters, you must pick the character with the MOST OCCURENCES in that word.
    //Then you must REPLACE every character in the word with that character.Example: “hello” = “lllll”.
    //Upon reading an input line, you should validate and process it. Then you should print the result of the processing.Only after that you should read the next input line.
    //The input ends when you receive the command “Worm Ipsum”.
    public class WormIpsum
    {
        public static void Main()
        {
            var validationRx = new Regex(@"^([A-Z].*[\.])$");
            var wordRx = new Regex(@"\w+");
            var input = Console.ReadLine();
            while (input != "Worm Ipsum")
            {
                var validInput = validationRx.Match(input);
                if (validInput.Success && validInput.Value.Where(x => x == '.').Count() < 2)
                {
                    var words = wordRx.Matches(validInput.Value).Cast<Match>().Select(x => x.Value).ToArray();
                    var result = validInput.Value;
                    foreach (var word in words)
                    {
                        var charDict = new Dictionary<char, int>();
                        foreach (var ch in word)
                        {
                            if (!charDict.ContainsKey(ch))
                            {
                                charDict.Add(ch, 0);
                            }
                            charDict[ch]++;
                        }
                        var maxCharOccurances = charDict.Max(x => x.Value);
                        var maxChar = charDict.Where(x => x.Value == maxCharOccurances).First().Key;
                        if (maxCharOccurances >= 2)
                        {
                            var wordLength = word.Length;
                            var newWord = new string(maxChar, wordLength);
                            result = result.Replace(word, newWord);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(result);
                    Console.ResetColor();
                }
                input = Console.ReadLine();
            }
        }
    }
}
