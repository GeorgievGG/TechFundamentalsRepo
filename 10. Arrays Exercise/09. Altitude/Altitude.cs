using System;

namespace _09.Altitude
{
    public class Altitude
    {
        public static void Main()
        {
            string[] navigationInfo = Console.ReadLine().Split(' ');
            double height = double.Parse(navigationInfo[0]);
            for (int i = 1; i < navigationInfo.Length; i++)
            {
                string direction = navigationInfo[i];
                i++;
                if (direction == "up")
                {
                    height = IncreaseHeight(navigationInfo, height, i);
                }
                else if (direction == "down")
                {
                    height = DecreaseHeight(navigationInfo, height, i);
                    if (height <= 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }
            if (height > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {height}m");
            }
        }

        private static double DecreaseHeight(string[] navigationInfo, double height, int i)
        {
            height -= double.Parse(navigationInfo[i]);
            return height;
        }

        private static double IncreaseHeight(string[] navigationInfo, double height, int i)
        {
            height += double.Parse(navigationInfo[i]);
            return height;
        }
    }
}
