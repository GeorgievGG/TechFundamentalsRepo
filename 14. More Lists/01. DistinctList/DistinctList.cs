using System;
using System.Linq;

namespace _01.DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers = numbers.Distinct().ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
