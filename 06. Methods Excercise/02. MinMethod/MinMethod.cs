using System;

namespace _02.MinMethod
{
    public class MinMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMin(c, GetMin(a, b)));
        }
        static int GetMin(int num1, int num2)
        {
            return Math.Min(num1, num2);
        }
    }
}
