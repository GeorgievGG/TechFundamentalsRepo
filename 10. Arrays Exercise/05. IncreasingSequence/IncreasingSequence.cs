using System;
using System.Linq;

namespace _05.IncreasingSequence
{
    class IncreasingSequence
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int prevNumber = int.MinValue;
            string increasing = "Yes";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < prevNumber)
                {
                    increasing = "No";
                }
                prevNumber = numbers[i];
            }
            Console.WriteLine(increasing);
        }
    }
}
