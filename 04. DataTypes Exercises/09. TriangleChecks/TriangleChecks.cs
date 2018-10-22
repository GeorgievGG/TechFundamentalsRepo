using System;

namespace _09.TriangleChecks
{
    public class TriangleChecks
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Invalid Triangle.");
            }
            else
            {
                Console.WriteLine("Triangle is valid.");
                double aSquared = Math.Pow(a, 2);
                double bSquared = Math.Pow(b, 2);
                double cSquared = Math.Pow(c, 2);
                if (aSquared + bSquared == cSquared)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (aSquared + cSquared == bSquared)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (bSquared + cSquared == aSquared)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
        }
    }
}
