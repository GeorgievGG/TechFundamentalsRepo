using System;

namespace _9.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var currentNumber = i;
                var sum = 0;
                while (currentNumber != 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
