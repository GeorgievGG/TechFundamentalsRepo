using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine().Split(new char[] { ':', '(', ')', ';', ' ', '-', '.', ',', '\"', '!', '?', '$' }, StringSplitOptions.RemoveEmptyEntries);
            var isPalindrome = true;
            var palindromes = new HashSet<string>();
            foreach (var word in inputArray)
            {
                for (int i = 0; i < word.Length/2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
                isPalindrome = true;
            }
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}
