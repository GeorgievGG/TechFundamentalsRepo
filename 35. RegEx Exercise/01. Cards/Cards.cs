using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    public class Cards
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"([1]?[0-9AJKQ])[SHDC]";
            var matches = Regex.Matches(input, pattern);
            var output = new List<string>();
            foreach (Match mch in matches)
            {
                var power = 0;
                var isNumber = int.TryParse(mch.Groups[1].Value, out power);
                if (isNumber && power >= 2 && power <= 10)
                {
                    output.Add(mch.ToString());
                }
                else if (!isNumber)
                {
                    output.Add(mch.ToString());
                }
            }
            //for (int i = 0; i < input.Length - 1; i++)
            //{
            //    if (input[i] == '1' && input[i + 1] == '0')
            //    {
            //        if (Regex.IsMatch(input.Substring(i, 3), pattern))
            //        {
            //            matches.Add(Regex.Match(input.Substring(i, 3), pattern).ToString());
            //        }
            //        i++;
            //    }
            //    else
            //    {
            //        if (Regex.IsMatch(input.Substring(i, 2), pattern))
            //        {
            //            matches.Add(Regex.Match(input.Substring(i, 2), pattern).ToString());
            //        }
            //    }
            //    i++;
            //}
            Console.WriteLine(string.Join(", ", output)); 
        }
    }
}