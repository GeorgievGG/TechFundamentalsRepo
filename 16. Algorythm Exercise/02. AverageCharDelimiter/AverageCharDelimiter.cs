using System;

namespace _02.AverageCharDelimiter
{
    public class AverageCharDelimiter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var inputConcatStr = string.Join("", input);
            var charValSum = 0;
            var delimiter = ' ';
            var arr = new string[100];
            //arr['a'] = "baba";
            for (int i = 0; i < inputConcatStr.Length; i++)
            {
                charValSum += inputConcatStr[i];
            }
            delimiter = (char)(charValSum / inputConcatStr.Length);
            Console.WriteLine(string.Join(delimiter.ToString().ToUpper(), input));
        }
    }
}
