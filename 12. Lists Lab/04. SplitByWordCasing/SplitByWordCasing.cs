using System;
using System.Collections.Generic;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            bool hasUpper = false;
            bool hasLower = false;
            bool hasSymbol = false;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] >= 97 && input[i][j] <= 122)
                    {
                        hasLower = true;
                    }
                    else if (input[i][j] >= 65 && input[i][j] <= 90)
                    {
                        hasUpper = true;
                    }
                    else
                    {
                        hasSymbol = true;
                    }
                }
                if (hasLower == true && hasUpper == true && hasSymbol != true)
                {
                    mixedCase.Add(input[i]);
                }
                else if (hasLower == true && hasSymbol != true)
                {
                    lowerCase.Add(input[i]);
                }
                else if (hasUpper == true && hasSymbol != true)
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
                hasUpper = false;
                hasLower = false;
                hasSymbol = false;
            }
            Console.Write("Lower-case: ");
            for (int i = 0; i < lowerCase.Count; i++)
            {
                if (i != lowerCase.Count - 1)
                {
                    Console.Write(lowerCase[i] + ", ");
                }
                else
                {
                    Console.WriteLine(lowerCase[i]);
                }
            }
            Console.Write("Mixed-case: ");
            for (int i = 0; i < mixedCase.Count; i++)
            {
                if (i != mixedCase.Count - 1)
                {
                    Console.Write(mixedCase[i] + ", ");
                }
                else
                {
                    Console.WriteLine(mixedCase[i]);
                }
            }
            Console.Write("Upper-case: ");
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
