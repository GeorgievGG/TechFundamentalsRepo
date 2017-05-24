using System;

namespace _6.MathPower
{
    class MathPower
    {
        static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());
            Console.WriteLine($"{CalculatePoweredNum(num, power)}");
        }
        static double CalculatePoweredNum(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
