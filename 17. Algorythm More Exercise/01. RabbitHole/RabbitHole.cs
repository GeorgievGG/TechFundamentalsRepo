using System;
using System.Linq;

namespace _01.RabbitHole
{
    public class RabbitHole
    {
        public static void Main()
        {
            var actions = Console.ReadLine().Split(' ').ToList();
            var energy = int.Parse(Console.ReadLine());
            var position = 0;
            while (true)
            {
                var action = actions[position].Split('|');
                if (actions[position] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else if (action[0] == "Right")
                {
                    energy -= int.Parse(action[1]);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }
                    position = (position + int.Parse(action[1])) % actions.Count;
                }
                else if (action[0] == "Left")
                {
                    energy -= int.Parse(action[1]);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }
                    position = Math.Abs(position - int.Parse(action[1])) % actions.Count;
                }
                else if (action[0] == "Bomb")
                {
                    energy -= int.Parse(action[1]);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                    actions.RemoveAt(position);
                    position = 0;
                }
                if (actions[actions.Count - 1] != "RabbitHole")
                {
                    actions.RemoveAt(actions.Count - 1);
                }
                actions.Add("Bomb|" + energy);
                //Console.WriteLine(string.Join("-", action));
            }
        }
    }
}
