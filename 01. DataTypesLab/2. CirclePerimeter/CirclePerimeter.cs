using System;

namespace _2.CirclePerimeter
{
    public class CirclePerimeter
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159265358979323846264338327;
            Console.WriteLine("{0:f12}", (pi * 2 * r));
        }
    }
}
