using System;
using System.Collections.Generic;

namespace _03.ForumTopics
{
    public class ForumTopics
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var topics = new Dictionary<string, List<string>>();
            while (input != "filter")
            {
                var inputList = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (!topics.ContainsKey(inputList[0]))
                {
                    topics.Add(inputList[0], new List<string>());
                }
                for (int i = 1; i < inputList.Length; i++)
                {
                    if (!topics[inputList[0]].Contains(inputList[i]))
                    {
                        topics[inputList[0]].Add('#' + inputList[i]);
                    }
                }
                input = Console.ReadLine();
            }
            var tagsInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var containsAll = true;
            foreach (var topic in topics)
            {
                for (int tagIndex = 0; tagIndex < tagsInput.Length; tagIndex++)
                {
                    if (!topic.Value.Contains('#' + tagsInput[tagIndex]))
                    {
                        containsAll = false;
                    }
                }
                if (containsAll)
                {
                    Console.WriteLine($"{topic.Key} | {string.Join(", ", topic.Value)}");
                }
                containsAll = true;
            }
        }
    }
}
