using System;

namespace _5.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int x = i;
                int sum = 0;
                bool special = false;
                while (x != 0)
                {
                    sum += x % 10;
                    x = x / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
