using System;
using System.Collections.Generic;

namespace _04.SplitByWordCasing
{
    public class SplitByWordCasing
    {
        private const string UPPER_CASE_TYPE = "Upper-case";
        private const string MIXED_CASE_TYPE = "Mixed-case";
        private const string LOWER_CASE_TYPE = "Lower-case";

        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                Word word = AnalyzeString(input, i);
                PlaceWordInProperList(lowerCase, upperCase, mixedCase, word);
            }

            PrintChars(lowerCase, LOWER_CASE_TYPE);
            PrintChars(mixedCase, MIXED_CASE_TYPE);
            PrintChars(upperCase, UPPER_CASE_TYPE);
        }

        private static Word AnalyzeString(string[] input, int i)
        {
            var word = new Word(input[i]);
            for (int j = 0; j < input[i].Length; j++)
            {
                if (input[i][j] >= 97 && input[i][j] <= 122)
                {
                    word.HasLower = true;
                }
                else if (input[i][j] >= 65 && input[i][j] <= 90)
                {
                    word.HasUpper = true;
                }
                else
                {
                    word.HasSymbol = true;
                }
            }

            return word;
        }

        private static void PlaceWordInProperList(List<string> lowerCase, List<string> upperCase, List<string> mixedCase, Word word)
        {
            if (word.HasLower == true && word.HasSymbol != true)
            {
                lowerCase.Add(word.Content);
            }
            else if (word.HasUpper == true && word.HasSymbol != true)
            {
                upperCase.Add(word.Content);
            }
            else
            {
                mixedCase.Add(word.Content);
            }
        }

        private static void PrintChars(List<string> upperCase, string charType)
        {
            Console.Write($"{charType}: ");
            for (int i = 0; i < upperCase.Count; i++)
            {
                if (i != upperCase.Count - 1)
                {
                    Console.Write(upperCase[i] + ", ");
                }
                else
                {
                    Console.WriteLine(upperCase[i]);
                }
            }
        }
    }
}
