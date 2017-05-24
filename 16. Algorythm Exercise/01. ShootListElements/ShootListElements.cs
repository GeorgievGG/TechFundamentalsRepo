using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ShootListElements
{
    public class ShootListElements
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var numbers = new List<int>();
            var lastShot = 0;
            double average = 0;
            while (command != "stop")
            {
                if (command != "bang")
                {
                    numbers.Insert(0, int.Parse(command));
                }
                else
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShot}");
                        break;
                    }
                    average = numbers.Average();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers.Count == 1)
                        {
                            Console.WriteLine($"shot {numbers[0]}");
                            lastShot = numbers[i];
                            numbers.RemoveAt(0);
                            break;
                        }
                        if (numbers[i] < average)
                        {
                            Console.WriteLine($"shot {numbers[i]}");
                            lastShot = numbers[i];
                            numbers.RemoveAt(i);
                            break;
                        }
                    }
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        numbers[j]--;
                    }
                }
                command = Console.ReadLine();
                if (command == "stop" && numbers.Count == 0)
                {
                    Console.WriteLine($"you shot them all. last one was {lastShot}");
                }
            }
            if (numbers.Count != 0)
            {
                Console.WriteLine("survivors: " + string.Join(" ", numbers));
            }
        }
    }
}
