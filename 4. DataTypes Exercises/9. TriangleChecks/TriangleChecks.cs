using System;

namespace _09.TriangleChecks
{
    class TriangleChecks
    {
        static void Main()
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
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
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
