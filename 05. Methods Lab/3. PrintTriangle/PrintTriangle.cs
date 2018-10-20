using System;

namespace _3.PrintingTriangle
{
    public class PrintTriangle
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            PrintTop(size);
            PrintBottom(size);
        }

        private static void PrintBottom(int size)
        {
            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    PrintNum(j);
                }
                Console.WriteLine();
            }
        }

        private static void PrintTop(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    PrintNum(j);
                }
                Console.WriteLine();
            }
        }

        private static void PrintNum(int num)
        {
            Console.Write($"{num} ");
        }
    }
}
