using System;

namespace _01.HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
