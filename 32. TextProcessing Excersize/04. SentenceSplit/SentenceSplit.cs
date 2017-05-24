using System;
using System.Collections.Generic;

namespace _04.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();
            var texts = new List<string>();
            while (sentence.Contains(delimiter))
            {
                var delimiterIx = sentence.IndexOf(delimiter);
                texts.Add(sentence.Substring(0, delimiterIx));
                sentence = sentence.Substring(delimiterIx + delimiter.Length, sentence.Length - (delimiterIx + delimiter.Length));
            }
            texts.Add(sentence);
            Console.WriteLine("[" + string.Join(", ", texts) + "]");
        }
    }
}
