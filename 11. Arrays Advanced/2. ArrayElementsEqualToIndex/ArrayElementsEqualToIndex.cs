using System;
using System.Linq;

namespace _02.ArrayElementsEqualToIndex
{
    class ArrayElementsEqualToIndex
    {
        static void Main()
        {
            ulong[] numbers = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();
            for (uint i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
