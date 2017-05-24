using System;

namespace _01.HornetWings
{
    class HornetWings
    {
        static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var flapDistance = decimal.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());
            var rest = 5;
            var wingFlapsPS = 100;
            var distance = (decimal)wingFlaps / 1000 * flapDistance;
            var time = wingFlaps / wingFlapsPS + wingFlaps / endurance * rest;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
