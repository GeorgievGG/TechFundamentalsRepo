using System;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            var time = DateTime.Parse("1900-01-01 " + Console.ReadLine());
            var distance = long.Parse(Console.ReadLine());
            var timeFor1Step = long.Parse(Console.ReadLine());
            var duration = (distance * timeFor1Step) % (24 * 60 * 60);
            time = time.AddMinutes((double)duration/60);
            Console.WriteLine($"Time Arrival: {time.Hour:d2}:{time.Minute:d2}:{time.Second:d2}");
        }
    }
}
