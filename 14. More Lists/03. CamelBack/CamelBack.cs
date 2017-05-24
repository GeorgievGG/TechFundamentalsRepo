using System;
using System.Linq;

namespace _03.CamelBack
{
    class CamelBack
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var backSize = int.Parse(Console.ReadLine());
            var rounds = 0;
            if (numbers.Count == backSize)
            {
                Console.WriteLine("already stable: " + string.Join(" ", numbers));
            }
            else
            {
                while (numbers.Count > backSize)
                {
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(numbers.Count - 1);
                    rounds++;
                }
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", numbers));
            }
        }
    }
}
