using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var rx = new Regex(@">*[<]\(+['\-x]>");
            var fishes = rx.Matches(input).Cast<Match>().Select(m => m.Value).ToArray();
            var fishesList = new List<Fish>();
            var fishCount = 1;
            if (fishes.Length == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                foreach (var fish in fishes)
                {
                    var newFish = new Fish()
                    {
                        tailLength = fish.Where(x => x == '>').Count() - 1,
                        bodyLength = fish.Where(x => x == '(').Count(),
                        eye = fish[fish.LastIndexOf('>') - 1]
                    };
                    Console.WriteLine($"Fish {fishCount}: {fish}");
                    if (newFish.tailType != "None")
                    {
                        Console.WriteLine($"  Tail type: {newFish.tailType} ({newFish.tailLength * 2} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {newFish.tailType}");
                    }
                    Console.WriteLine($"  Body type: {newFish.bodyType} ({newFish.bodyLength * 2} cm)");
                    Console.WriteLine($"  Status: {newFish.status}");
                    fishCount++;
                }
            }
        }
        public class Fish
        {
            //public Fish(int tailLength, int bodyLength, char eye)
            //{
            //    this.tailLength = tailLength;
            //    this.bodyLength = bodyLength;
            //    this.eye = eye;
            //}
            public long tailLength { get; set; }
            public string tailType {
                get
                {
                    if (tailLength > 5)
                    {
                        return "Long";
                    }
                    else if (tailLength > 1)
                    {
                        return "Medium";
                    }
                    else if (tailLength == 1)
                    {
                        return "Short";
                    }
                    else
                    {
                        return "None";
                    }
                }
            }
            public long bodyLength { get; set; }
            public string bodyType {
                get
                {
                    if (bodyLength > 10)
                    {
                        return "Long";
                    }
                    else if (bodyLength > 5)
                    {
                        return "Medium";
                    }
                    else
                    {
                        return "Short";
                    }
                }
            }
            public char eye { get; set; }
            public string status
            {
                get
                {
                    switch (eye)
                    {
                        case '\'':
                            return "Awake";
                        case 'x':
                            return "Dead";
                        case '-':
                            return "Asleep";
                        default:
                            return "none";
                    }
                }
            }
        }
    }
}
