using System;
using System.Linq;

namespace _02.JapaneseRoulette
{
    public class JapaneseRoulette
    {
        public static void Main()
        {
            var cylinder = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var playerActions = Console.ReadLine().Split(' ').ToList();
            long bulletIndex = 0;
            var lucky = true;
            for (int i = 0; i < 6; i++)
            {
                if (cylinder[i] == 1)
                {
                    bulletIndex = i;
                }
            }
            for (int i = 0; i < playerActions.Count; i++)
            {
                var action = playerActions[i].Split(',');
                if (action[1] == "Right")
                {
                    bulletIndex += long.Parse(action[0]);
                    bulletIndex %= 6;
                }
                else if (action[1] == "Left")
                {
                    bulletIndex = bulletIndex - long.Parse(action[0]);
                    while (bulletIndex < 0)
                    {
                        bulletIndex += 6;
                    }
                }
                if (bulletIndex == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    lucky = false;
                    break;
                }
                bulletIndex++;
            }
            if (lucky)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
