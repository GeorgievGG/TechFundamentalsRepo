using System;

namespace _01.LastThreeConsecutive
{
    public class LastThreeConsecutive
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            int repeatedStringPosition = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                int repeatedWords = 0;
                for (int j = i; j < strings.Length; j++)
                {
                    string comparedWord = strings[i];
                    string currentWord = strings[j];
                    repeatedWords = IncreaseIfRepeated(repeatedWords, comparedWord, currentWord);

                    if (repeatedWords == 3)
                    {
                        repeatedStringPosition = i;
                        continue;
                    }
                }
            }

            PrintChosenStrings(strings, repeatedStringPosition);
        }

        private static int IncreaseIfRepeated(int repeatedWords, string comparedWord, string currentWord)
        {
            if (comparedWord == currentWord)
            {
                repeatedWords++;
            }
            else
            {
                repeatedWords = 0;
            }

            return repeatedWords;
        }

        private static void PrintChosenStrings(string[] strings, int repeatedStringPosition)
        {
            for (int k = repeatedStringPosition; k < repeatedStringPosition + 3; k++)
            {
                Console.Write($"{strings[k]} ");
            }
        }
    }
}
