using System;

namespace _3.ExactSum
{
    class ExactSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal num = 0;
            for (int i = 0; i < n; i++)
            {
                 num += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}
