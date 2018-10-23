using System;
using System.Linq;

namespace _10.Ballistics
{
    public class Ballistics
    {
        public static void Main()
        {
            double[] shootingCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string[] navigationInfo = Console.ReadLine().Split(' ');
            double x = 0;
            double y = 0;
            string direction = string.Empty;
            for (int i = 0; i < navigationInfo.Length; i++)
            {
                direction = navigationInfo[i];
                i++;
                if (direction == "up")
                {
                    y = IncreaseHeight(navigationInfo, y, i);
                }
                else if (direction == "down")
                {
                    y = DecreaseHeight(navigationInfo, y, i);
                }
                else if (direction == "left")
                {
                    x = TurnLeft(navigationInfo, x, i);
                }
                else if (direction == "right")
                {
                    x = TurnRight(navigationInfo, x, i);
                }
            }

            Console.WriteLine($"firing at [{x}, {y}]");

            PrintRersult(shootingCoordinates, x, y);
        }

        private static double TurnRight(string[] navigationInfo, double x, int i)
        {
            x += double.Parse(navigationInfo[i]);
            return x;
        }

        private static double TurnLeft(string[] navigationInfo, double x, int i)
        {
            x -= double.Parse(navigationInfo[i]);
            return x;
        }

        private static double DecreaseHeight(string[] navigationInfo, double y, int i)
        {
            y -= double.Parse(navigationInfo[i]);
            return y;
        }

        private static double IncreaseHeight(string[] navigationInfo, double y, int i)
        {
            y += double.Parse(navigationInfo[i]);
            return y;
        }

        private static void PrintRersult(double[] coordinates, double x, double y)
        {
            if (x == coordinates[0] && y == coordinates[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
