using System;

namespace _4.DrawFilledSquare
{
    public class DrawFilledSquare
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            PrintRoof(size);
            PrintBody(size);
            PrintBottom(size);
        }

        private static void PrintRoof(int num)
        {
            for (int i = 0; i < num * 2; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }

        private static void PrintBody(int num)
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

        private static void PrintBottom(int num)
        {
            for (int i = 0; i < num * 2; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }
}
