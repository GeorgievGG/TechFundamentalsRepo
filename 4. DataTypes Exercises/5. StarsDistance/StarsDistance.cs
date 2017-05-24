using System;

namespace _05.StarsDistance
{
    class StarsDistance
    {
        static void Main()
        {
            decimal num1 = 4.22M * 9450000000000;
            decimal num2 = 26000M * 9450000000000;
            decimal num3 = 100000M * 9450000000000;
            decimal num4 = 46500000000M * 9450000000000;
            Console.WriteLine($@"{num1.ToString("e2")}
{num2.ToString("e2")}
{num3.ToString("e2")}
{num4.ToString("e2")}");
        }
    }
}
