using System;

namespace _4.DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            PrintRoof(num);
            PrintBody(num);
            PrintBottom(num);
        }
        static void PrintRoof(int num)
        {
            for (int i = 0; i < num * 2; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
        static void PrintBody(int num)
        {
            for (int i = 0; i < num - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < num - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write('-');
                Console.WriteLine();
            }
        }
        static void PrintBottom(int num)
        {
            for (int i = 0; i < num * 2; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }
}
