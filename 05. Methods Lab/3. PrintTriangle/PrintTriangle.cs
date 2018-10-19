using System;

namespace _3.PrintingTriangle
{
    class PrintTriangle
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    PrintNum(j);
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    PrintNum(j);
                }
                Console.WriteLine();
            }
        }
        static void PrintNum(int num)
        {
            Console.Write($"{num} ");
        }
    }
}
