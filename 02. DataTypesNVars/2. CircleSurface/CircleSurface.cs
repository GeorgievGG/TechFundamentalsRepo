using System;

namespace _2.CircleSurface
{
    public class CircleSurface
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159265358979323846264338327;
            double surface = pi * Math.Pow(r, 2);
            Console.WriteLine("{0:f12}", surface);
        }
    }
}
