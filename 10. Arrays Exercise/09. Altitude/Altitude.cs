using System;

namespace _09.Altitude
{
    class Altitude
    {
        static void Main()
        {
            string[] navigationInfo = Console.ReadLine().Split(' ');
            string direction = "";
            double height = double.Parse(navigationInfo[0]);
            for (int i = 1; i < navigationInfo.Length; i++)
            {
                direction = navigationInfo[i];
                i++;
                if (direction == "up")
                {
                    height += double.Parse(navigationInfo[i]);
                }
                else if (direction == "down")
                {
                    height -= double.Parse(navigationInfo[i]);
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
    }
}
