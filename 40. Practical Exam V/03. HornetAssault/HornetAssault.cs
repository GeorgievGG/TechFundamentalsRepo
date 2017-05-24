using System;
using System.Linq;

namespace _03.HornetAssault
{
    class HornetAssault
    {
        static void Main()
        {
            var beehiveGroup = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var hornetPower = Console.ReadLine().Split().Select(long.Parse).Reverse().ToList();
            for (int i = 0; i < beehiveGroup.Length; i++)
            {
                var summedPower = hornetPower.Sum();
                if (beehiveGroup[i] >= summedPower)
                {
                    if (hornetPower.Count > 0)
                    {
                        hornetPower.RemoveAt(hornetPower.Count - 1);
                    }
                }
                beehiveGroup[i] -= Math.Min(summedPower, beehiveGroup[i]);
            }
            hornetPower.Reverse();
            if (beehiveGroup.Where(x => x > 0).Count() > 0)
            {
                Console.WriteLine(string.Join(" ", beehiveGroup.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetPower));
            }
        }
    }
}
