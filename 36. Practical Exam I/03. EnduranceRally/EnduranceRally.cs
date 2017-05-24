using System;
using System.Linq;

namespace _03.EnduranceRally
{
    class EnduranceRally
    {
        static void Main()
        {
            var contenders = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var fuelUnits = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).Select(double.Parse).ToList();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse);
            var passedStages = 0;
            for (int player = 0; player < contenders.Length; player++)
            {
                var fuel = (double)contenders[player][0];
                for (int stage = 0; stage < fuelUnits.Count(); stage++)
                {
                    if (checkpoints.Contains(stage))
                    {
                        fuel += fuelUnits[stage];
                    }
                    else
                    {
                        fuel -= fuelUnits[stage];
                    }
                    if (fuel <= 0)
                    {
                        break;
                    }
                    passedStages++;
                }
                if (passedStages == fuelUnits.Count())
                {
                    Console.WriteLine($"{contenders[player]} - fuel left {fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{contenders[player]} - reached {passedStages}");
                }
                passedStages = 0;
            }
        }
    }
}
