using System;

namespace _08.LightspeedTravel
{
    public class LightspeedTravel
    {
        public static void Main()
        {
            decimal lightYearKm = 9450000000000 * decimal.Parse(Console.ReadLine());
            decimal speedOfLight = 300000;
            decimal remainingSeconds = (lightYearKm / speedOfLight);
            decimal weeks = remainingSeconds / 60 / 60 / 24 / 7;
            remainingSeconds %= (60 * 60 * 24 * 7);
            decimal days = remainingSeconds / 60 / 60 / 24;
            remainingSeconds %= (60 * 60 * 24);
            decimal hours = remainingSeconds / 60 / 60;
            remainingSeconds %= (60 * 60);
            decimal minutes = remainingSeconds / 60;
            remainingSeconds %= 60;
            Console.WriteLine($"{Math.Floor(weeks)} weeks");
            Console.WriteLine($"{Math.Floor(days)} days");
            Console.WriteLine($"{Math.Floor(hours)} hours");
            Console.WriteLine($"{Math.Floor(minutes)} minutes");
            Console.WriteLine($"{Math.Floor(remainingSeconds)} seconds");
        }
    }
}
