using System;
using System.Linq;

namespace _06.PowerPlants
{
    class PowerPlants
    {
        static void Main()
        {
            int[] plantsPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int nthDay = plantsPower.Length;
            int days = 0;
            int seasons = 0;
            while (true)
            {
                for (int i = 0; i < plantsPower.Length; i++)
                {
                    if (i == days % nthDay)
                    {
                        plantsPower[i]++;
                    }
                    plantsPower[i]--;
                }
                days++;
                if (plantsPower.Max() == 0)
                {
                    break;
                }
                if (days % nthDay == 0)
                {
                    seasons++;
                    for (int i = 0; i < plantsPower.Length; i++)
                    {
                        plantsPower[i]++;
                    }
                }
            }
            if (seasons == 1)
            {
                Console.WriteLine($"survived {days} days ({seasons} season)");
            }
            else
            {
                Console.WriteLine($"survived {days} days ({seasons} seasons)");
            }
        }
    }
}
