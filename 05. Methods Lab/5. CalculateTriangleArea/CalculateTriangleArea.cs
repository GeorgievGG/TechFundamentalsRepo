using System;

namespace _5.CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{CalculateArea(a,b)}");
        }

        private static double CalculateArea (double a, double b)
        {
            return a * b / 2;
        }
    }
}
