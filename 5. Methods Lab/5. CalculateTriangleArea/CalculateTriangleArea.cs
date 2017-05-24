using System;

namespace _5.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{CalculateArea(a,b)}");
        }
        static double CalculateArea (double a, double b)
        {
            return a * b / 2;
        }
    }
}
