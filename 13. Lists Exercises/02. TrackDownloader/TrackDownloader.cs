using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TrackDownloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklist = Console.ReadLine().Split(' ').ToList();
            var input = Console.ReadLine();
            var isBlacklisted = false;
            var result = new List<string>();
            while (input != "end")
            {
                for (int i = 0; i < blacklist.Count; i++)
                {
                    isBlacklisted = input.Contains(blacklist[i]);
                    if (isBlacklisted)
                    {
                        break;
                    }
                }
                if (!isBlacklisted)
                {
                    result.Add(input);
                }
                isBlacklisted = false;
                input = Console.ReadLine();
            }
            result.Sort();
            foreach (var title in result)
            {
                Console.WriteLine(title);
            }
        }
    }
}
