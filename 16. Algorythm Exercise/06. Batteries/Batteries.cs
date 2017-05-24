using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Batteries
{
    public class Batteries
    {
        public static void Main()
        {
            var batteriesPower = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var initialPower = new List<double>(batteriesPower);
            var batteriesUsagePH = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var tests = int.Parse(Console.ReadLine());

            for (int batteryID = 0; batteryID < batteriesPower.Count; batteryID++)
            {
                for (int hour = 0; hour < tests; hour++)
                {
                    batteriesPower[batteryID] -= batteriesUsagePH[batteryID];
                    if (batteriesPower[batteryID] <= 0)
                    {
                        Console.WriteLine($"Battery {batteryID + 1}: dead (lasted {hour + 1} hours)");
                        break;
                    }
                }
                if (batteriesPower[batteryID] > 0)
                {
                    Console.WriteLine($"Battery {batteryID + 1}: {batteriesPower[batteryID]:f2} mAh ({batteriesPower[batteryID] / initialPower[batteryID] * 100:N2})%");
                }
            }
        }
    }
}
