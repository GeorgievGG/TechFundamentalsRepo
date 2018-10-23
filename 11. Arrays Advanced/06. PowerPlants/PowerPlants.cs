using System;
using System.Linq;

namespace _06.PowerPlants
{
    public class PowerPlants
    {
        public static void Main()
        {
            int[] plantsPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int nthDay = plantsPower.Length;
            int days = 0;
            int seasons = 0;
            while (true)
            {
                ManagePlantsPower(plantsPower, nthDay, days);

                days++;

                bool allPlantsDied = plantsPower.Max() == 0;
                if (allPlantsDied)
                {
                    break;
                }

                bool seasonHasEnded = days % nthDay == 0;
                if (seasonHasEnded)
                {
                    seasons = IncreaseSeasons(plantsPower, seasons);
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

        private static void ManagePlantsPower(int[] plantsPower, int nthDay, int days)
        {
            for (int i = 0; i < plantsPower.Length; i++)
            {
                if (i == days % nthDay)
                {
                    plantsPower[i]++;
                }

                plantsPower[i]--;
            }
        }

        private static int IncreaseSeasons(int[] plantsPower, int seasons)
        {
            seasons++;
            Bloom(plantsPower);

            return seasons;
        }

        private static void Bloom(int[] plantsPower)
        {
            for (int i = 0; i < plantsPower.Length; i++)
            {
                plantsPower[i]++;
            }
        }
    }
}
