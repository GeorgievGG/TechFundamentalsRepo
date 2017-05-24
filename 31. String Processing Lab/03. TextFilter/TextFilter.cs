using System;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                input = input.Replace(bannedWords[i], new String('*', bannedWords[i].Length));
            }
            Console.WriteLine(input);
        }
    }
}
