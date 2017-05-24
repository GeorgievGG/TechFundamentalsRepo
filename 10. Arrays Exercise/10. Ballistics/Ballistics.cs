using System;
using System.Linq;

namespace _10.Ballistics
{
    class Ballistics
    {
        static void Main()
        {
            double[] coordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string[] navigationInfo = Console.ReadLine().Split(' ');
            double x = 0;
            double y = 0;
            string direction = "";
            for (int i = 0; i < navigationInfo.Length; i++)
            {
                direction = navigationInfo[i];
                i++;
                if (direction == "up")
                {
                    y += double.Parse(navigationInfo[i]);
                }
                else if (direction == "down")
                {
                    y -= double.Parse(navigationInfo[i]);
                }
                else if (direction == "left")
                {
                    x -= double.Parse(navigationInfo[i]);
                }
                else if (direction == "right")
                {
                    x += double.Parse(navigationInfo[i]);
                }
            }
            Console.WriteLine($"firing at [{x}, {y}]");
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
