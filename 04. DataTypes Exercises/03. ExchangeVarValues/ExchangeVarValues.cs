using System;

namespace _03.ExchangeVarValues
{
    public class ExchangeVarValues
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
