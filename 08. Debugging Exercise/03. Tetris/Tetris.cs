using System;

namespace Tetris_Broken
{
    public class Tetris
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "up":
                        ExecuteUpCommand(size);
                        break;
                    case "right":
                        ExecuteRightCommand(size);
                        break;
                    case "down":
                        ExecuteDownCommand(size);
                        break;
                    case "left":
                        ExecuteLeftCommand(size);
                        break;
                }
                currentDirection = Console.ReadLine();
            }
        }

        private static void ExecuteLeftCommand(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', size) + new string('*', size));
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', 2 * size));
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', size) + new string('*', size));
            }
        }

        private static void ExecuteRightCommand(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', size) + new string('.', size));
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', 2 * size));
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', size) + new string('.', size));
            }
        }

        private static void ExecuteUpCommand(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', size) + new string('*', size) + new string('.', size));
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', size * 3));
            }
        }

        private static void ExecuteDownCommand(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', size * 3));
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('.', size) + new string('*', size) + new string('.', size));
            }
        }
    }
}