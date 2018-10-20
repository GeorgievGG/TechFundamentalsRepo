using System;

namespace _6.MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine($"{CalculatePoweredNum(num, power)}");
        }

        private static double CalculatePoweredNum(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
